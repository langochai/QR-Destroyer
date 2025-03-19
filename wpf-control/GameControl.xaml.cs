using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using wpf_control.Models;

namespace wpf_control
{
    public partial class GameControl : UserControl
    {
        private Storyboard currentStoryboard = new Storyboard();
        private double dx = 0;
        private double dy = 0;

        public double speedFactor = 0.5;
        public List<QRs> QRs = new List<QRs>();

        public string[] imagePaths =
        {
            "Images/qr1.png",
            "Images/qr2.png",
            "Images/qr3.png",
            "Images/qr4.png",
            "Images/qr5.png",
            "Images/qr6.png",
        };

        public int currentIndex = 5;

        private readonly Random random = new Random();

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
            RespawnImage();
            AnimateImage();
        }

        public void RespawnImage()
        {
            if (currentStoryboard != null)
            {
                currentStoryboard.Stop();
                currentStoryboard = null;
            }
            MainCanvas.Children.Remove(BouncingImage);

            currentIndex = (currentIndex + 1) % imagePaths.Length;
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var filePath = Path.Combine(baseDir, "Images", QRs[currentIndex].FileName);
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(filePath, UriKind.Absolute);
            bitmap.CacheOption = BitmapCacheOption.OnLoad;
            bitmap.EndInit();
            bitmap.Freeze();
            BouncingImage = new Image
            {
                Width = 150,
                Height = 150,
                Source = bitmap,
                Stretch = System.Windows.Media.Stretch.Uniform
            };

            MainCanvas.Children.Add(BouncingImage);

            double newX = random.NextDouble() * (MainCanvas.ActualWidth - BouncingImage.Width);
            double newY = random.NextDouble() * (MainCanvas.ActualHeight - BouncingImage.Height);
            Canvas.SetLeft(BouncingImage, newX);
            Canvas.SetTop(BouncingImage, newY);

            dx = random.Next(2) == 0 ? -3 : 3;
            dy = random.Next(2) == 0 ? -3 : 3;

            AnimateImage();
        }

        private void AnimateImage()
        {
            double currentX = Canvas.GetLeft(BouncingImage);
            double currentY = Canvas.GetTop(BouncingImage);

            double newX = currentX + dx * speedFactor;
            double newY = currentY + dy * speedFactor;

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

            Storyboard sb = new Storyboard();
            TimeSpan duration = TimeSpan.FromMilliseconds(20);
            DoubleAnimation animX = new DoubleAnimation
            {
                From = currentX,
                To = newX,
                Duration = new Duration(duration),
                FillBehavior = FillBehavior.Stop
            };
            Storyboard.SetTarget(animX, BouncingImage);
            Storyboard.SetTargetProperty(animX, new PropertyPath("(Canvas.Left)"));
            sb.Children.Add(animX);
            DoubleAnimation animY = new DoubleAnimation
            {
                From = currentY,
                To = newY,
                Duration = new Duration(duration),
                FillBehavior = FillBehavior.Stop
            };
            Storyboard.SetTarget(animY, BouncingImage);
            Storyboard.SetTargetProperty(animY, new PropertyPath("(Canvas.Top)"));
            sb.Children.Add(animY);
            sb.Completed += (s, e) =>
            {
                Canvas.SetLeft(BouncingImage, newX);
                Canvas.SetTop(BouncingImage, newY);
                AnimateImage();
            };
            currentStoryboard = sb;
            sb.Begin();
        }
    }
}