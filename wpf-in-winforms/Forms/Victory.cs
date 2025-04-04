using System.Media;
using System.Windows.Forms;

namespace wpf_in_winforms.Forms
{
    public partial class Victory : Form
    {
        public GameFrame game;
        public Victory(GameFrame g)
        {
            InitializeComponent();
            game = g;
            lblAnnounce.Parent = picBackground;
            int rank = SqliteHelper<CustomersOld>.GetRank(game.customer.Id);
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