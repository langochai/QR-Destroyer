using System;
using System.Windows.Forms;

namespace wpf_in_winforms
{
    public partial class Settings : Form
    {
        public GameFrame gameFrame;

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Shown(object sender, EventArgs e)
        {
            int[] availableSpeeds = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int speed = Properties.Settings.Default.Speed;
            cboSpeed.SelectedIndex = Array.IndexOf(availableSpeeds, speed);
        }

        private void cboSpeed_SelectedValueChanged(object sender, EventArgs e)
        {
            int speed = Convert.ToInt32(cboSpeed.Text);
            Properties.Settings.Default["Speed"] = speed;
            gameFrame.ChangeSpeed(speed);
        }
    }
}