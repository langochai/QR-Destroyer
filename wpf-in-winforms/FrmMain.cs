using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using wpf_in_winforms.Fonts;
using wpf_in_winforms.Forms;
using wpf_in_winforms.Models;

namespace wpf_in_winforms
{
    public partial class FrmMain : Form
    {
        public Scanner scanner;
        public FrmMain()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.DoubleBuffer, true);
            bool registered = FontRegister.Register();
            if (registered) btnStart.Font = new Font(FontRegister.JoystickFont.Families[0], 36);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                var InterestIDs = new List<int>();
                if (chkInterest1.Checked) InterestIDs.Add(1);
                if (chkInterest2.Checked) InterestIDs.Add(2);
                if (chkInterest3.Checked) InterestIDs.Add(3);
                if (chkInterest4.Checked) InterestIDs.Add(4);
                if (chkInterest5.Checked) InterestIDs.Add(5);
                if (chkInterest6.Checked) InterestIDs.Add(6);
                if (chkInterest7.Checked) InterestIDs.Add(7);
                var ChannelIDs = new List<int>();
                if (chkChannel1.Checked) ChannelIDs.Add(1);
                if (chkChannel2.Checked) ChannelIDs.Add(2);
                if (chkChannel3.Checked) ChannelIDs.Add(3);
                if (chkChannel4.Checked) ChannelIDs.Add(4);
                if (chkChannel5.Checked) ChannelIDs.Add(5);

                //var newCustomer = new Customers
                //{
                //    Name = txtName.Text,
                //    Company = txtCompany.Text,
                //    Email = txtEmail.Text,
                //    PhoneNumber = txtPhoneNumber.Text,
                //    PlayTime = 100000,
                //    InterestIds = JsonConvert.SerializeObject(InterestIDs),
                //    ChannelIds = JsonConvert.SerializeObject(ChannelIDs),
                //    CreatedDate = DateTime.Now,
                //};
                var newCustomer = new Customers
                {
                    FullName = txtName.Text,
                    Company = txtCompany.Text,
                    EmailAdress = txtEmail.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    PlayTime = 100000,
                    SmartWarehouseSolutions = chkInterest1.Checked,
                    MachineVisionSolutions = chkInterest2.Checked,
                    AGVnAMRSolutions = chkInterest3.Checked,
                    AutomaticMachineManufacturingSolutions = chkInterest4.Checked,
                    AutomationEquipmentinProduction = chkInterest5.Checked,
                    IoTSolutions = chkInterest6.Checked,
                    OtherSolutions = chkInterest7.Checked,
                    MailChannel = chkChannel1.Checked,
                    WebsiteChannel = chkChannel2.Checked,
                    FacebookChannel = chkChannel3.Checked,
                    PartnersChannel = chkChannel4.Checked,
                    OtherChannel = chkChannel5.Checked,
                    CreatedDate = DateTime.Now,
                };
                //newCustomer.Id = SqliteHelper<Customers>.Insert(newCustomer);
                Weapons weapon = new Weapons(this);
                this.Hide();
                if (weapon.ShowDialog() != DialogResult.OK)
                {
                    this.Show();
                    return;
                }
                newCustomer.Id = SqliteHelper<Customers>.Insert(newCustomer);
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
                txtCompany.Text = txtEmail.Text = txtName.Text = txtPhoneNumber.Text = "";
                foreach (var ctrl in this.Controls)
                {
                    if (ctrl is CheckBox checkbox) checkbox.Checked = false;
                }
                frmGame.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool ValidateInputs()
        {
            return !(String.IsNullOrWhiteSpace(txtName.Text) || String.IsNullOrWhiteSpace(txtEmail.Text) ||
                String.IsNullOrWhiteSpace(txtCompany.Text) || String.IsNullOrWhiteSpace(txtPhoneNumber.Text)) &&
                (chkInterest1.Checked || chkInterest2.Checked || chkInterest3.Checked || chkInterest4.Checked ||
                chkInterest5.Checked || chkInterest6.Checked || chkInterest7.Checked) &&
                (chkChannel1.Checked || chkChannel2.Checked || chkChannel3.Checked || chkChannel4.Checked || chkChannel5.Checked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtName.Text = "Gigachad";
            txtEmail.Text = "giggachad@gmail.com";
            txtCompany.Text = "GIGACHAD COMPANY";
            txtPhoneNumber.Text = "0123456789";
            chkInterest1.Checked = chkChannel1.Checked = true;
            btnStart_Click(null, null);
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
            txtName.Text = "Gigachad";
            txtEmail.Text = "giggachad@gmail.com";
            txtCompany.Text = "GIGACHAD COMPANY";
            txtPhoneNumber.Text = "0123456789";
            chkInterest1.Checked = chkChannel1.Checked = true;
            btnStart_Click(null, null);
        }

    }
}