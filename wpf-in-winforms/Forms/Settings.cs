using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace wpf_in_winforms
{
    public partial class Settings : Form
    {
        public GameFrame gameFrame;
        public List<Label> paths = new List<Label>();
        public List<TextBox> contents = new List<TextBox>();

        public Settings()
        {
            InitializeComponent();
            paths.AddRange(new[] { txtQR1Path, txtQR2Path, txtQR3Path, txtQR4Path, txtQR5Path, txtQR6Path });
            contents.AddRange(new[] { txtQR1Content, txtQR2Content, txtQR3Content, txtQR4Content, txtQR5Content, txtQR6Content });
        }

        private void Settings_Shown(object sender, EventArgs e)
        {
            int[] availableSpeeds = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int speed = Properties.Settings.Default.Speed;
            cboSpeed.SelectedIndex = Array.IndexOf(availableSpeeds, speed);
            for (int index = 0; index < 6; index++)
            {
                var i = index; // save the current index because of closure
                paths[i].Text = Convert.ToString(Properties.Settings.Default["QR" + (i + 1) + "Path"]);
                contents[i].Text = Convert.ToString(Properties.Settings.Default["QR" + (i + 1) + "Content"]);
                paths[i].Click += (object snd, EventArgs eve) =>
                {
                    try
                    {
                        var filename = OpenSaveFileForm(Convert.ToString(Properties.Settings.Default["QR" + (i + 1) + "Path"]));
                        if (string.IsNullOrWhiteSpace(filename)) return;
                        paths[i].Text = filename;
                        Properties.Settings.Default["QR" + (i + 1) + "Path"] = filename;
                        Properties.Settings.Default.Save();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                };
                contents[i].KeyDown += (object snd, KeyEventArgs eve) =>
                {
                    if (eve.KeyCode == Keys.Enter)
                    {
                        if (string.IsNullOrWhiteSpace(contents[i].Text))
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            Properties.Settings.Default["QR" + (i + 1) + "Content"] = contents[i].Text;
                            Properties.Settings.Default.Save();
                        }
                    }
                };
            }
        }

        private void cboSpeed_SelectedValueChanged(object sender, EventArgs e)
        {
            int speed = Convert.ToInt32(cboSpeed.Text);
            Properties.Settings.Default["Speed"] = speed;
            Properties.Settings.Default.Save();
            gameFrame.ChangeSpeed(speed);
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            gameFrame.SetQRSettings();
        }

        private string OpenSaveFileForm(string currentFileName)
        {
            Image File;
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png";
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            if (f.ShowDialog() == DialogResult.OK)
            {
                if (f.SafeFileName == currentFileName) throw new Exception("Vui lòng chọn tên file khác");
                File = Image.FromFile(f.FileName);
                File.Save(Path.Combine(baseDir, "Images", f.SafeFileName));
                return f.SafeFileName;
            }
            else
            {
                return "";
            }
        }
    }
}