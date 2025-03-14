using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Media;
using System.Windows.Forms;
using wpf_control;
using wpf_in_winforms.Fonts;

namespace wpf_in_winforms
{
    public partial class GameFrame : Form
    {
        private SortableBindingList<Customers> customers = new SortableBindingList<Customers>();
        private readonly List<PictureBox> Stars = new List<PictureBox>();

        private List<String> answers = new List<string> {
            "rtc-placeholder1","rizzler-of-rtc","skibidi-toilet","giga-chad-of-rtc","customer-fanum-list","humongous-gyatt"
        };

        public GameFrame()
        {
            InitializeComponent();
            eleHost.Child = new GameControl();
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

        public void NextQR()
        {
            PlaySound();
            if (!(eleHost.Child is GameControl game)) return;
            Stars[game.currentImg].Image = Properties.Resources.star;
            if (game.currentImg == 5)
            {
                eleHost.Child = null;
                MessageBox.Show("Bạn là người chiến thắng!!!", "You won!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            game.RespawnImage();
            //game.speedFactor += 0.3;
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

        #region Kết nối tới scanner

        private SerialPort scannerSerialPort;

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
                scannerSerialPort = new SerialPort(SerialPort.GetPortNames()[0], 600, parity, 7, (StopBits)1);
                scannerSerialPort.ReadTimeout = 1000;
                scannerSerialPort.WriteTimeout = 1000;
                scannerSerialPort.Open();
                scannerSerialPort.DataReceived -= Com_DataReceived;
                scannerSerialPort.DataReceived += Com_DataReceived;
            }
            catch (Exception)
            {
                MessageBox.Show("Thiết bị chưa được kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                txtQRResult.BeginInvoke(new Action(() =>
                {
                    txtQRResult.Text = sp.ReadExisting();
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi cực kì nhỏ đã xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion Kết nối tới scanner
    }
}