using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Media;
using System.Windows.Forms;
using wpf_control;
using wpf_control.Models;
using wpf_in_winforms.Fonts;
using wpf_in_winforms.Forms;
using wpf_in_winforms.Models;

namespace wpf_in_winforms
{
    public partial class GameFrame : Form
    {
        public Customers customer;
        public Scanner scanner;
        private SortableBindingList<CustomersView> customers = new SortableBindingList<CustomersView>();
        private readonly List<PictureBox> Stars = new List<PictureBox>();
        private List<QRs> QRs = new List<QRs>();
        private Stopwatch stopwatch = new Stopwatch();
        public bool isTrialPlay = false;
        public bool isPlaying = false;

        public GameFrame()
        {
            InitializeComponent();
        }

        private void GameFrame_Load(object sender, EventArgs e)
        {
            grvRank.AutoGenerateColumns = false;
            DisplayRank();
        }

        private void InitializeGame()
        {
            eleHost.Child = new GameControl();
            ChangeSpeed(Properties.Settings.Default.Speed);
            SetQRSettings();
            Stars.AddRange(new[] { star1, star2, star3, star4, star5, star6 });
            ConnectCom();
            stopwatch.Start();
            GameTick.Start();
            DisplayFonts();
        }

        private void StopGame()
        {
            stopwatch.Reset();
            lblPlayTime.Text = "00:00";
            foreach (var star in Stars) { star.Image = Properties.Resources.star_new_disabled; }
            eleHost.Child = null;
            if (scannerSerialPort != null)
            {
                scannerSerialPort.Close();
                scannerSerialPort.Dispose();
                scannerSerialPort = null;
            }
        }

        public void DisplayRank()
        {
            customers = new SortableBindingList<CustomersView>(SqliteHelper<CustomersView>.GetCustomerView());
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

        private void DisplayFonts()
        {
            lblRanking.Font = new Font(FontRegister.JoystickFont.Families[0], 20);
            lblPlayTime.Font = new Font(FontRegister.MonoFont.Families[0], 36);
        }

        private void grvRank_SizeChanged(object sender, EventArgs e)
        {
            grvRank.RowTemplate.Height = (grvRank.Height - grvRank.ColumnHeadersHeight) / 10;
        }

        private void PlaySound()
        {
            var soundPlayer = new SoundPlayer("./Sounds/bonus.wav");
            soundPlayer.Play();
        }

        public void ChangeSpeed(int speed)
        {
            if (!(eleHost.Child is GameControl game)) return;
            game.speedFactor = 2.5 * (speed + 1);
        }

        #region Kết nối tới scanner

        public SerialPort scannerSerialPort;

        private void ConnectCom()
        {
            try
            {
                if (scannerSerialPort != null)
                {
                    scannerSerialPort.Close();
                    scannerSerialPort.Dispose();
                    scannerSerialPort = null;
                }
                Parity parity = (Parity)Enum.Parse(typeof(Parity), scanner.Pairity, true);
                scannerSerialPort = new SerialPort(scanner.PortName, scanner.BaudRate, parity, scanner.DataBits, (StopBits)scanner.StopBits)
                {
                    ReadTimeout = 1000,
                    WriteTimeout = 1000
                };
                scannerSerialPort.Open();
                scannerSerialPort.DataReceived -= Com_DataReceived;
                scannerSerialPort.DataReceived += Com_DataReceived;
            }
            catch (Exception)
            {
                MessageBox.Show("Thiết bị chưa được kết nối hoặc không có quyền truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                string textResult = sp.ReadExisting();
                PlaySound();
                if (!(eleHost.Child is GameControl game)) return;
                var index = game.currentIndex;
                bool isCorrect = textResult.Trim() == QRs[index].Content;
                if (!isCorrect) return;
                Stars[index].BeginInvoke(new Action(() =>
                {
                    Stars[index].Image = Properties.Resources.star_new;
                }));
                if (index == 5) HandleVictory();
                game.Dispatcher.BeginInvoke(new Action(() => { game.RespawnImage(); }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi cực kì nhỏ đã xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void HandleVictory()
        {
            eleHost.BeginInvoke(new Action(() => { eleHost.Child = null; }));
            stopwatch.Stop();
            GameTick.Stop();
            if (isTrialPlay)
            {
                this.BeginInvoke(new Action(() =>
                {
                    Victory frm = new Victory(this);
                    frm.ShowDialog();
                }));
            }
            else
            {
                customer.PlayTime = Convert.ToInt32(stopwatch.Elapsed.TotalSeconds);
                SqliteHelper<Customers>.Update(customer);
                grvRank.BeginInvoke(new Action(() => { DisplayRank(); }));
                this.BeginInvoke(new Action(() =>
                {
                    Victory frm = new Victory(this);
                    frm.ShowDialog();
                }));
            }
            isPlaying = false;
        }

        #endregion Kết nối tới scanner

        private void picSetting_Click(object sender, EventArgs e)
        {
            Settings frm = new Settings();
            frm.gameFrame = this;
            frm.ShowDialog();
        }

        public void SetQRSettings()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            for (int i = 1; i < 7; i++)
            {
                QRs.Add(new QRs
                {
                    FileName = Path.Combine(baseDir, "Images", Convert.ToString(Properties.Settings.Default["QR" + i + "Path"])),
                    Content = Convert.ToString(Properties.Settings.Default["QR" + i + "Content"])
                });
            }
            if (!(eleHost.Child is GameControl game)) return;
            game.QRs = QRs;
        }

        private void GameTick_Tick(object sender, EventArgs e)
        {
            //this.BeginInvoke(new Action(() =>
            //{
            TimeSpan elapsed = stopwatch.Elapsed;
            lblPlayTime.Text = $"{elapsed.Minutes:D2}:{elapsed.Seconds:D2}";
            //}));
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

        private void btnTrialPlay_Click(object sender, EventArgs e)
        {
            if (isPlaying) return;
            isTrialPlay = true;
            StopGame();
            InitializeGame();
            isPlaying = true;
        }

        private void btnActualPlay_Click(object sender, EventArgs e)
        {
            if (isPlaying) return;
            isTrialPlay = false;
            StopGame();
            if (customer.PlayTime > 0 && customer.PlayTime < 100000) { 
                MessageBox.Show("Bạn đã hoàn thành lượt chơi của mình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isPlaying = false;
            }
            else InitializeGame();
            isPlaying = true;
        }
    }
}