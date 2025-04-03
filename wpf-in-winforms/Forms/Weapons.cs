using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using wpf_in_winforms.Models;
using wpf_in_winforms.UC;

namespace wpf_in_winforms.Forms
{
    public partial class Weapons : Form
    {
        private readonly FrmMain main;
        private List<Scanner> scanners;
        private List<WeaponShowCase> weapons = new List<WeaponShowCase>();

        public Weapons(FrmMain m)
        {
            InitializeComponent();
            this.main = m;
            try
            {
                scanners = GetScanners();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            LoadScannerInfo();
        }

        private void LoadScannerInfo()
        {
            try
            {
                for (int i = 0; i < scanners.Count; i++)
                {
                    int currentIndex = i;
                    WeaponShowCase wp = new WeaponShowCase(scanners[i], currentIndex);
                    wp.OnPickWeapon += ChangePickedWeapon;
                    this.Controls.Add(wp);
                    weapons.Add(wp);
                }
                int totalGap = 150 * (weapons.Count + 1);
                for (int i = 0; i < weapons.Count; i++)
                {
                    var width = (this.Width - totalGap) / weapons.Count;
                    var height = this.Height - 300;
                    weapons[i].Size = new Size(width, height);
                    weapons[i].Location = new Point(150 + i * (width + 150), 150);
                }
            }
            catch
            {
            }
        }
        public void ChangePickedWeapon(int pickedIndex)
        {
            for (int i = 0; i < weapons.Count; i++)
            {
                if (i != pickedIndex && weapons[i].isClicked)
                    weapons[i].HandleClickWeapon(false);
            }
            WeaponDetails wpd = new WeaponDetails(scanners[pickedIndex]);
            this.Hide();
            var result = wpd.ShowDialog();
            if (result != DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                main.scanner = scanners[pickedIndex];
                this.DialogResult = DialogResult.OK;
            }
        }
        public static List<Scanner> GetScanners()
        {
            string settingsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Scanner.json");
            if (File.Exists(settingsFilePath))
            {
                string jsonString = File.ReadAllText(settingsFilePath);
                var scanner = JsonConvert.DeserializeObject<List<Scanner>>(jsonString)
                    ?? throw new InvalidOperationException("Không tìm thấy thông tin Scanner");
                return scanner;
            }
            else
            {
                throw new FileNotFoundException("Không tìm được file Scanner.json");
            }
        }

        private void Weapons_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var weapon in weapons) { weapon.TurnOffVid(); }
        }
    }
}