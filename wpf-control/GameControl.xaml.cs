using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace wpf_control
{
    public partial class GameControl : UserControl
    {
        private DispatcherTimer timer;

        private double dx = 0;
        private double dy = 0;

        public double speedFactor = 0.5;

        public int currentImg = 0;
        private string[] imagePaths =
        {
            "Images/qr1.png",
            "Images/qr2.png",
            "Images/qr3.png",
            "Images/qr4.png",
            "Images/qr5.png",
            "Images/qr6.png",
        };

        private Random random = new Random();

        public GameControl()
        {
            InitializeComponent();
            dx = random.Next(2) == 0 ? -3 : 3;
            dy = random.Next(2) == 0 ? -3 : 3;
            this.Loaded += ScreenSaverControl_Loaded;
        }

        private void ScreenSaverControl_Loaded(object sender, RoutedEventArgs e)
        {
            double canvasWidth = MainCanvas.ActualWidth;
            double canvasHeight = MainCanvas.ActualHeight;
            double imgWidth = BouncingImage.Width;
            double imgHeight = BouncingImage.Height;

            double initialX = random.NextDouble() * (canvasWidth - imgWidth);
            double initialY = random.NextDouble() * (canvasHeight - imgHeight);
            Canvas.SetLeft(BouncingImage, initialX);
            Canvas.SetTop(BouncingImage, initialY);

            timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(5)
            };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            double x = Canvas.GetLeft(BouncingImage);
            double y = Canvas.GetTop(BouncingImage);

            double newX = x + dx * speedFactor;
            double newY = y + dy * speedFactor;

            double canvasWidth = MainCanvas.ActualWidth;
            double canvasHeight = MainCanvas.ActualHeight;

            double imgWidth = BouncingImage.ActualWidth;
            double imgHeight = BouncingImage.ActualHeight;

            if (newX < 0)
            {
                newX = 0;
                dx = -dx;
            }
            else if (newX + imgWidth > canvasWidth)
            {
                newX = canvasWidth - imgWidth;
                dx = -dx;
            }

            if (newY < 0)
            {
                newY = 0;
                dy = -dy;
            }
            else if (newY + imgHeight > canvasHeight)
            {
                newY = canvasHeight - imgHeight;
                dy = -dy;
            }

            Canvas.SetLeft(BouncingImage, newX);
            Canvas.SetTop(BouncingImage, newY);
        }

        public void RespawnImage()
        {
            MainCanvas.Children.Remove(BouncingImage);
            currentImg = (currentImg + 1) % imagePaths.Length;
            BouncingImage = new Image
            {
                Width = 150,
                Height = 150,
                Source = new BitmapImage(new Uri(imagePaths[currentImg], UriKind.Relative)),
                Stretch = System.Windows.Media.Stretch.Uniform
            };

            MainCanvas.Children.Add(BouncingImage);

            double newX = random.NextDouble() * (MainCanvas.ActualWidth - BouncingImage.Width);
            double newY = random.NextDouble() * (MainCanvas.ActualHeight - BouncingImage.Height);

            Canvas.SetLeft(BouncingImage, newX);
            Canvas.SetTop(BouncingImage, newY);

            dx = random.Next(2) == 0 ? -3 : 3;
            dy = random.Next(2) == 0 ? -3 : 3;
        }
    }
}