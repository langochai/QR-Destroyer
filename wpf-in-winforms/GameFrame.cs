using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using wpf_control;

namespace wpf_in_winforms
{
    public partial class GameFrame : Form
    {
        private SortableBindingList<Customer> customers = new SortableBindingList<Customer>();
        private readonly List<PictureBox> Stars = new List<PictureBox>();

        private List<String> answers = new List<string> {
            "rtc-placeholder1","rizzler-of-rtc","skibidi-toilet","giga-chad-of-rtc","customer-fanum-list","humongous-gyatt"
        };

        public GameFrame()
        {
            InitializeComponent();
            eleHost.Child = new GameControl();
            customers.Add(new Customer { Id = 0, Name = "Giga Chad", Company = "AAA", Score = 3 });
            customers.Add(new Customer { Id = 0, Name = "Wimpy Beta", Company = "BBB", Score = 1 });
            customers.Add(new Customer { Id = 0, Name = "Sigma of the Company", Company = "CCC", Score = 2 });
            Stars.AddRange(new[] { star1, star2, star3, star4, star5, star6 });
            DisplayRank();
        }

        public void DisplayRank()
        {
            grvRank.DataSource = customers;
            grvRank.Sort(grvRank.Columns["colScore"], ListSortDirection.Descending);
        }

        public void NextQR()
        {
            if (!(eleHost.Child is GameControl game)) return;
            Stars[game.currentImg].Image = Properties.Resources.star;
            if (game.currentImg == 5)
            {
                eleHost.Child = null;
                MessageBox.Show("Chiến thắng!!!", "You won!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            game.RespawnImage();
            game.speedFactor += 0.3;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (!(eleHost.Child is GameControl game)) return;
            var currentIndex = cboQRValue.SelectedIndex;
            if (currentIndex == game.currentImg) NextQR();
        }
    }
}