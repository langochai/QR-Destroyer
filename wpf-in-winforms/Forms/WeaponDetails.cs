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
            lblName.Text = scanner.Name;
            picPartner.Image = scanner.Logo == "MobyData"? Properties.Resources.MobyData : Properties.Resources.HoneyWell;
            pic1.Image = scanner.Logo == "MobyData"? Properties.Resources.md1 : Properties.Resources.hw1;
            pic2.Image = scanner.Logo == "MobyData"? Properties.Resources.md2 : Properties.Resources.hw2;
            pic3.Image = scanner.Logo == "MobyData"? Properties.Resources.md1 : Properties.Resources.hw3;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}