using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using wpf_in_winforms.Fonts;
using wpf_in_winforms.Models;

namespace wpf_in_winforms.UC
{
    public partial class WeaponShowCase : UserControl
    {
        private Scanner scanner;
        public bool isClicked = false;
        public event Action<int> OnPickWeapon;
        public int weaponIndex = 0;

        public WeaponShowCase(Scanner s, int idx)
        {
            InitializeComponent();
            scanner = s;
            weaponIndex = idx;
            DisplayData();
            lblName.Font = new Font(FontRegister.JoystickFont.Families[0], 26);
        }

        private void DisplayData()
        {
            try
            {
                lblName.Text = scanner.Name;
                lblDescription.Text = scanner.Description;
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                var picPath = Path.Combine(baseDir, "ScannerData", scanner.Picture);
                var vidPath = Path.Combine(baseDir, "ScannerData", scanner.Video);
                var placeholderPath = Path.Combine(baseDir, "ScannerData", "placeholder.jpg");
                bool hasVideo = File.Exists(vidPath);
                bool hasPic = File.Exists(picPath);
                if (hasVideo)
                {
                    picAbout.Visible = false;
                    vidAbout.Visible = true;
                    vidAbout.URL = vidPath;
                    vidAbout.settings.volume = 100;
                    vidAbout.settings.mute = true;
                    vidAbout.settings.setMode("loop", true);
                    vidAbout.uiMode = "none";
                    vidAbout.Ctlcontrols.play();
                }
                else if (hasPic && !hasVideo)
                {
                    vidAbout.Visible = false;
                    picAbout.Visible = true;
                    picAbout.Image = Image.FromFile(picPath);
                }
                else
                {
                    vidAbout.Visible = false;
                    picAbout.Visible = true;
                    picAbout.Image = Image.FromFile(placeholderPath);
                }
            }
            catch
            {
            }
        }

        public void TurnOffVid()
        {
            vidAbout.Ctlcontrols.stop();
            vidAbout.URL = "";
            vidAbout.close();
            vidAbout.Dispose();
        }

        private void WeaponShowCase_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = !isClicked ? new Pen(Color.Black, 3f) : new Pen(Color.OrangeRed, 5f))
            {
                //pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                //pen.DashPattern = new float[] { 5, 5 };
                Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
                e.Graphics.DrawRectangle(pen, rect);
            }
        }
        public void HandleClickWeapon(bool clicked)
        {
            isClicked = clicked;
            this.Invalidate();
            this.Update();
            this.Refresh();
        }
        public void WeaponShowCase_Click(object sender = null, EventArgs e = null)
        {
            OnPickWeapon?.Invoke(weaponIndex);
            HandleClickWeapon(true);
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            WeaponShowCase_Click();
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {
            WeaponShowCase_Click();
        }

        private void picAbout_Click(object sender, EventArgs e)
        {
            WeaponShowCase_Click();
        }
    }
}