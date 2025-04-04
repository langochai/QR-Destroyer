using System;
using System.Drawing;
using System.Windows.Forms;
using wpf_in_winforms.Fonts;
using wpf_in_winforms.Models;

namespace wpf_in_winforms.Forms
{
    public partial class WeaponDetails : Form
    {
        private Scanner scanner;

        public WeaponDetails(Scanner s)
        {
            InitializeComponent();
            scanner = s;
            btnStart.Font = new Font(FontRegister.JoystickFont.Families[0], 26);
            if (scanner.Logo == "HoneyWell") pictureBox1.Image = Properties.Resources.dt1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}