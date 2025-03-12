using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_control
{
    /// <summary>
    /// Interaction logic for MoveableControl.xaml
    /// </summary>
    public partial class MoveableControl : UserControl
    {
        public MoveableControl()
        {
            InitializeComponent();
        }
        private void MoveButton_Click(object sender, RoutedEventArgs e)
        {
            // Target positions
            double targetX = 300;
            double targetY = 200;

            // Create the animations
            DoubleAnimation moveXAnimation = new DoubleAnimation
            {
                To = targetX,
                Duration = TimeSpan.FromSeconds(1)
            };

            DoubleAnimation moveYAnimation = new DoubleAnimation
            {
                To = targetY,
                Duration = TimeSpan.FromSeconds(1)
            };

            // Set the target properties for the animations
            Storyboard.SetTarget(moveXAnimation, myButton);
            Storyboard.SetTargetProperty(moveXAnimation, new PropertyPath("(Canvas.Left)"));

            Storyboard.SetTarget(moveYAnimation, myButton);
            Storyboard.SetTargetProperty(moveYAnimation, new PropertyPath("(Canvas.Top)"));

            // Create the storyboard and add the animations
            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(moveXAnimation);
            storyboard.Children.Add(moveYAnimation);

            // Start the storyboard
            storyboard.Begin();
        }
    }
}
