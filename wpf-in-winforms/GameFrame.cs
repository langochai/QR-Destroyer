using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using wpf_control;
using wpf_control.Models;
using wpf_in_winforms.Fonts;

namespace wpf_in_winforms
{
    public partial class GameFrame : Form
    {
        public Customers customer;
        private SortableBindingList<Customers> customers = new SortableBindingList<Customers>();
        private readonly List<PictureBox> Stars = new List<PictureBox>();
        private List<QRs> QRs = new List<QRs>();

        public GameFrame()
        {
            InitializeComponent();
            eleHost.Child = new GameControl();
            ChangeSpeed(Properties.Settings.Default.Speed);
            SetQRSettings();
            grvRank.DataSource = customers;
            Stars.AddRange(new[] { star1, star2, star3, star4, star5, star6 });
            DisplayRank();
            DisplayPixelFont();
            Connect();
        }

        public void DisplayRank()
        {
            customers = new SortableBindingList<Customers>(SqliteHelper<Customers>.GetAll());
            grvRank.Sort(grvRank.Columns["colPlayTime"], ListSortDirection.Ascending);
        }

        private void DisplayPixelFont()
        {
            lblGameName.Font = new Font(FontRegister.Font.Families[0], 40);
        }

        private void PlaySound()
        {
            var soundPlayer = new SoundPlayer("./Sounds/ting.wav");
            soundPlayer.Play();
        }

        public void ChangeSpeed(int speed)
        {
            if (!(eleHost.Child is GameControl game)) return;
            game.speedFactor = 2.5 * (speed + 1);
        }

        #region Kết nối tới scanner

        public SerialPort scannerSerialPort;

        private void Connect()
        {
            try
            {
                if (scannerSerialPort != null)
                {
                    scannerSerialPort.Close();
                    scannerSerialPort.Dispose();
                    scannerSerialPort = null;
                }
                Parity parity = (Parity)Enum.Parse(typeof(Parity), "NONE", true);
                scannerSerialPort = new SerialPort(SerialPort.GetPortNames()[0], 600, parity, 7, (StopBits)1)
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
                txtQRResult.BeginInvoke(new Action(() =>
                {
                    txtQRResult.Text = textResult;
                }));
                if (!(eleHost.Child is GameControl game)) return;
                bool isCorrect = string.Concat(textResult.Where(c => !char.IsWhiteSpace(c))) == QRs[game.currentIndex].Content;
                if (!isCorrect) return;
                PlaySound();
                Stars[game.currentIndex].BeginInvoke(new Action(() =>
                {
                    Stars[game.currentIndex].Image = Properties.Resources.star;
                }));
                if (game.currentIndex == 5)
                {
                    // lưu thời gian vào db
                    eleHost.BeginInvoke(new Action(() => { eleHost.Child = null; }));
                    MessageBox.Show("Bạn là người chiến thắng!!!", "You won!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                game.Dispatcher.BeginInvoke(new Action(() => { game.RespawnImage(); }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi cực kì nhỏ đã xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
    }
}