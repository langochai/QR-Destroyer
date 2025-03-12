using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace wpf_control
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class WPFCarousel : UserControl
    {
        private int _currentScreenIndex = 0;
        private readonly UserControl[] _screens;

        public WPFCarousel()
        {
            InitializeComponent();
            _screens = new UserControl[] { new Screen1(), new Screen2(), new Screen3() };
            ContentArea.Content = _screens[_currentScreenIndex];
        }

        private void AnimateTransition(UserControl newScreen, string animationKey)
        { 
            ContentArea.RenderTransform = new TranslateTransform(); 
            var storyboard = (Storyboard)FindResource(animationKey); 
            storyboard.Completed += (s, e) => { 
                ContentArea.Content = newScreen; 
                if (animationKey == "SlideOutAnimation") { 
                    var slideIn = (Storyboard)FindResource("SlideInAnimation"); 
                    slideIn.Begin(ContentArea); 
                } 
            }; 
            storyboard.Begin(ContentArea); 
        }

        private void PrevButton_Click(object sender, RoutedEventArgs e)
        { 
            if (_currentScreenIndex > 0) { 
                _currentScreenIndex--; 
                AnimateTransition(_screens[_currentScreenIndex], "SlideOutAnimation"); 
            } 
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        { 
            if (_currentScreenIndex < _screens.Length - 1) { 
                _currentScreenIndex++; 
                AnimateTransition(_screens[_currentScreenIndex], "SlideOutAnimation"); 
            } 
        }
    }
}