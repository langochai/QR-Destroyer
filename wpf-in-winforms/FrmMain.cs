﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using wpf_in_winforms.Fonts;

namespace wpf_in_winforms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            var registered = FontRegister.Register();
            if (registered) DisplayPixelFont();
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

                var newCustomer = new Customers
                {
                    Name = txtName.Text,
                    Company = txtCompany.Text,
                    Email = txtEmail.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    PlayTime = 0,
                    InterestIds = JsonConvert.SerializeObject(InterestIDs),
                    ChannelIds = JsonConvert.SerializeObject(ChannelIDs),
                    CreatedDate = DateTime.Now,
                };
                SqliteHelper<Customers>.Insert(newCustomer);
                GameFrame frm = new GameFrame();
                frm.customer = newCustomer;
                frm.FormClosed += (s, ev) => {
                    frm.scannerSerialPort.Close();
                    frm.scannerSerialPort.Dispose();
                    frm.scannerSerialPort = null;
                    this.Show();
                };
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DisplayPixelFont()
        {
            btnStart.Font = new Font(FontRegister.Font.Families[0], 40);
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
    }
}