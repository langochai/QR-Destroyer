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
    public partial class StartScreen : Form
    {
        public Scanner scanner;
        public StartScreen()
        {
            InitializeComponent();
        }

        private void StartScreen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FrmMainNew frm = new FrmMainNew();
                frm.FormClosed += (s, evt) =>
                {
                    this.Show();
                };
                frm.Show();
                this.Hide();
            }
        }
    }
}