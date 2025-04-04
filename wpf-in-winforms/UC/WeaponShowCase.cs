using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using wpf_in_winforms.Models;

namespace wpf_in_winforms.UC
{
    public partial class WeaponShowCase : UserControl
    {
        public Scanner scanner;
        public bool isClicked = false;

        public event Action<int> OnPickWeapon;

        private int weaponIndex = 0;
        private Image weaponImage;

        public WeaponShowCase()
        {
            InitializeComponent();
            //lblName.Font = new Font(FontRegister.JoystickFont.Families[0], 55);
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
            OnPickWeapon?.Invoke(WeaponIndex);
            HandleClickWeapon(true);
        }

        [Category("Custom")]
        [Description("Index of the selected weapon.")]
        public int WeaponIndex
        {
            get => weaponIndex;
            set
            {
                weaponIndex = value;
            }
        }

        [Category("Custom")]
        [Description("Image of the selected weapon.")]
        public Image WeaponImage
        {
            get => weaponImage;
            set
            {
                weaponImage = value;
                picWeapon.Image = weaponImage;
                Invalidate();
            }
        }

        private int radius = 100;

        [DefaultValue(100)]
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                this.RecreateRegion();
            }
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void RecreateRegion()
        {
            var bounds = ClientRectangle;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(bounds.Left, bounds.Top, bounds.Right, bounds.Bottom, Radius, radius));
            this.Invalidate();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.RecreateRegion();
        }
    }
}