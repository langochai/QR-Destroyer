using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wpf_in_winforms.Models;

namespace wpf_in_winforms.Forms
{
    public partial class Summary : Form
    {
        public Summary()
        {
            InitializeComponent();
            grvRank.AutoGenerateColumns = false;
            DisplayRank();
        }
        public void DisplayRank()
        {
            var customers = new SortableBindingList<CustomersView>(SqliteHelper<CustomersView>.GetCustomerView());
            if (customers.Count < 10)
            {
                var missingCount = 10 - customers.Count;
                for (int i = 0; i < missingCount; i++) { customers.Add(new CustomersView()); }
            }
            grvRank.DataSource = customers;
            grvRank.Sort(grvRank.Columns["colPlayTime"], ListSortDirection.Ascending);
            grvRank.RowTemplate.Height = (grvRank.Height - grvRank.ColumnHeadersHeight) / 11;
            grvRank.Refresh();
            grvRank.ClearSelection();
            grvRank.CurrentCell = null;
        }
        private void grvRank_SizeChanged(object sender, EventArgs e)
        {
            grvRank.RowTemplate.Height = (grvRank.Height - grvRank.ColumnHeadersHeight) / 10;
        }
        private void grvRank_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == grvRank.Columns["colRank"].Index && e.RowIndex >= 0)
            {
                e.PaintBackground(e.CellBounds, true);
                //e.PaintContent(e.CellBounds);

                string rankText = e.Value?.ToString() ?? "";
                Image rankImage = GetRankImage(rankText);

                if (rankImage != null)
                {
                    int imgSize = 36;
                    Point imgLocation = new Point(e.CellBounds.Right - imgSize - 5, e.CellBounds.Y + (e.CellBounds.Height - imgSize) / 2);
                    e.Graphics.DrawImage(rankImage, new Rectangle(imgLocation, new Size(imgSize, imgSize)));
                }

                e.Handled = true;
            }
        }

        private Image GetRankImage(string rank)
        {
            switch (rank)
            {
                case "0":
                    return null;

                case "1":
                    return Properties.Resources.medal_gold;

                case "2":
                    return Properties.Resources.medal_silver;

                case "3":
                    return Properties.Resources.medal_bronze;

                default:
                    return Properties.Resources.medal_noob;
            }
        }

        private void grvRank_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (grvRank.Columns[e.ColumnIndex].ValueType == typeof(int))
            {
                int value = (int)e.Value;
                if (value == 0)
                {
                    e.Value = string.Empty;
                    e.FormattingApplied = true;
                }
            }
            if (e.ColumnIndex == grvRank.Columns["colPlayTime"].Index && e.RowIndex >= 0)
            {
                if (e.Value != null)
                {
                    e.Value = e.Value.ToString() + "s";
                    e.FormattingApplied = true;
                }
            }
        }

        private void grvRank_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grvRank.ClearSelection();
            grvRank.CurrentCell = null;
        }

        private void Summary_Shown(object sender, EventArgs e)
        {
            grvRank.ClearSelection();
            grvRank.CurrentCell = null;
        }
    }
}
