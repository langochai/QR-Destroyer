﻿using System.Drawing;
using System.Media;
using System.Windows.Forms;
using wpf_in_winforms.Models;

namespace wpf_in_winforms.Forms
{
    public partial class Victory : Form
    {
        public GameFrame game;
        public Victory(GameFrame g)
        {
            InitializeComponent();
            game = g;
            lblAnnounce.Parent = lblPlaytime.Parent = picBackground;
            int rank = SqliteHelper<CustomersOld>.GetRank(game.customer.Id);
            lblPlaytime.Text = $"Thời gian chơi: {string.Format("{0:N2}s", g.stopwatch.Elapsed.TotalSeconds)}";
            if (game.isTrialPlay)
            {
                lblAnnounce.Text = "Bạn đã hoàn thành lượt chơi";
            }
            else
                switch (rank)
                {
                    case 1:
                        lblAnnounce.Text = "Quá tuyệt vời!!!\nBạn đang là nhà vô địch của trò chơi này!!!";
                        break;
                    case 2:
                        lblAnnounce.Text = "Quá tuyệt vời!!!\nBạn đang đứng vị trí thứ hai trên bảng xếp hạng!!";
                        break;
                    case 3:
                        lblAnnounce.Text = "Quá tuyệt vời!!!\nBạn đang đứng vị trí thứ ba trên bảng xếp hạng!!";
                        break;
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        lblAnnounce.Text = "Quá tuyệt vời!!!\nBạn đã có mặt trong top 10 trên bảng xếp hạng!!";
                        break;
                    default:
                        lblAnnounce.Text = "Xin chúc mừng!\nBạn đã hoàn thành trò chơi!";
                        break;
                }
            PlaySound();
        }
        private static SoundPlayer player;

        public static void PlaySound()
        {
            player = new SoundPlayer("./Sounds/cheers.wav");
            player.PlayLooping();
        }

        public static void StopSound()
        {
            player.Stop();
        }

        private void Victory_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopSound();
        }
    }
}