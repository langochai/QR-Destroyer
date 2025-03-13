using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            GameFrame frm = new GameFrame();
            frm.Show();
        }
        private void DisplayPixelFont()
        {
            btnStart.Font = new Font(FontRegister.Font.Families[0], 40);
        }
    }
}
