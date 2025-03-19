using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using wpf_in_winforms.Models;

namespace wpf_in_winforms.UC
{
    public partial class WeaponShowCase : UserControl
    {
        private Scanner scanner;
        private bool isClicked = false;

        public WeaponShowCase(Scanner s)
        {
            InitializeComponent();
            scanner = s;
            DisplayData();
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

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Pen dashedPen = !isClicked ? new Pen(Color.Black, 1f) : new Pen(Color.OrangeRed, 1f))
            {
                dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                dashedPen.DashPattern = new float[] { 15, 15 };
                Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
                e.Graphics.DrawRectangle(dashedPen, rect);
            }
        }

        private void WeaponShowCase_Click(object sender = null, EventArgs e = null)
        {
            isClicked = !isClicked;
            this.Invalidate();
            this.Update();
            this.Refresh();
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