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
            int rank = SqliteHelper<Customers>.GetRank(game.customer.Id);
            if (game.isTrialPlay)
            {
                lblAnnounce.Text = "Bạn đã hoàn thành lượt chơi";
            }
            else 
                switch (rank)
                {
                    case 1:
                        lblAnnounce.Text = "Quá tuyệt vời!!! Bạn chính là người chơi xuất sắc nhất quả đất!!!";
                        break;
                    case 2:
                        lblAnnounce.Text = "Thật xuất sắc!! Bạn đã dành được vị trí thứ hai trên bảng xếp hạng!!";
                        break;
                    case 3:
                        lblAnnounce.Text = "Xin chúc mừng! Bạn đã dành được vị trí thứ ba trên bảng xếp hạng!";
                        break;
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        lblAnnounce.Text = "Xin chúc mừng! Bạn đã nằm trong top 10 những người chơi tuyệt vời nhất!";
                        break;
                    default:
                        lblAnnounce.Text = "Bạn là người chiến thắng!";
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