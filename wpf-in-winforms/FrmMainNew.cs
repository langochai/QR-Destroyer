﻿using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
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
                var customerTask = GetCustomerAsync(txtSTT.Text);
                Weapons weapon = new Weapons(this);
                this.Hide();
                if (weapon.ShowDialog() != DialogResult.OK)
                {
                    this.Show();
                    return;
                }
                var customer = await customerTask;
                string customerName;
                if (customer == null)
                {
                    customerName = $"Người chơi {new Random().Next(1, 200)}";
                }
                else if (customer.Status == 0)
                {
                    MessageBox.Show(
                      "Bạn chưa đăng ký STT, vui lòng liên hệ nhân viên quầy để được giúp đỡ",
                      "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    customerName = customer.Data.FullName;
                }
                var newCustomer = new Customers
                {
                    CustomerId = Convert.ToInt32(txtSTT.Text),
                    FullName = customerName,
                    PlayTime = 100000,
                    Stage = GetStage(),
                    CreatedDate = DateTime.Now,
                };
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
                txtSTT.Text = "";
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

        private void txtSTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private async Task<CustomerAPI> GetCustomerAsync(string id)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(5);
                    var apiUrl = $"http://192.168.1.2:8080/luckynumber/customer/GetByID?id={id}";
                    var json = await client.GetStringAsync(apiUrl).ConfigureAwait(false);
                    return JsonConvert.DeserializeObject<CustomerAPI>(json);
                }
            }
            catch
            {
                return null;
            }
        }
    }
}