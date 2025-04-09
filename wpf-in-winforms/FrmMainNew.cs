using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;
using wpf_in_winforms.Fonts;
using wpf_in_winforms.Forms;
using wpf_in_winforms.Models;

namespace wpf_in_winforms
{
    public partial class FrmMainNew : Form
    {
        public Scanner scanner;
        public FrmMainNew()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.DoubleBuffer, true);
            bool registered = FontRegister.Register();
            if (registered) btnStart.Font = new Font(FontRegister.JoystickFont.Families[0], 36);
            var btns = new Button[] { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btnBackspace, btnReset };
            foreach (Button b in btns)
            {
                b.Click += button_clicked;
                b.Paint += button_Paint;
            }
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                var customerName = "";
                try
                {
                    var client = new HttpClient();
                    var response = await client.GetStringAsync($"api and shit");
                    var result = JsonConvert.DeserializeObject<CustomerAPI>(response);
                    if (result == null || result.Status == 0)
                    {
                        MessageBox.Show("Bạn chưa đăng ký STT, vui lòng liên hệ nhân viên quầy để được giúp đỡ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        customerName = result.Data.FullName;
                    }
                }
                catch
                {
                    customerName = $"Người chơi {(new Random()).Next(1, 200)}";
                }

                var newCustomer = new Customers
                {
                    CustomerId = Convert.ToInt32(txtSTT.Text),
                    FullName = customerName,
                    PlayTime = 100000,
                    Stage = GetStage(),
                    CreatedDate = DateTime.Now,
                };
                Weapons weapon = new Weapons(this);
                this.Hide();
                if (weapon.ShowDialog() != DialogResult.OK)
                {
                    this.Show();
                    return;
                }
                SqliteHelper<Customers>.Insert(newCustomer);
                GameFrame frmGame = new GameFrame
                {
                    customer = newCustomer,
                    scanner = scanner
                };
                frmGame.FormClosed += (s, ev) =>
                {
                    frmGame.scannerSerialPort?.Close();
                    frmGame.scannerSerialPort?.Dispose();
                    frmGame.scannerSerialPort = null;
                    this.Show();
                };
                this.Hide();
                frmGame.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private bool ValidateInputs()
        {

            return int.TryParse(txtSTT.Text, out _);
        }
        protected override CreateParams CreateParams //prevent flickering
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        private void btnSummary_Click(object sender, EventArgs e)
        {
            Summary sm = new Summary();
            sm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtSTT.Text = "1";
            btnStart_Click(null, null);
        }
        private void button_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ((Button)sender).ClientRectangle,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }
        private void button_clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            switch (button.Tag.ToString())
            {
                case "delete":
                    txtSTT.Text = txtSTT.Text.Length > 1 ? txtSTT.Text.Substring(0, txtSTT.Text.Length - 1) : "";
                    break;
                case "reset":
                    txtSTT.Text = "";
                    break;
                default:
                    txtSTT.Text += button.Tag.ToString();
                    break;
            }
        }
        private static int GetStage()
        {
            var now = DateTime.Now;
            DateTime anchor = new DateTime(2025, 4, 16, 12, 0, 0);

            const double hoursPerSlot = 12;
            const int maxSlot = 6;

            double hoursSinceAnchor = (now - anchor).TotalHours;

            if (hoursSinceAnchor < 0)
                return 1;

            int slot = (int)(hoursSinceAnchor / hoursPerSlot) + 2;

            return slot > maxSlot ? maxSlot : slot;
        }

    }
}