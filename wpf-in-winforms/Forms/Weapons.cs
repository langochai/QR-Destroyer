using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using wpf_in_winforms.Fonts;
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
            btnStart.Font = new Font(FontRegister.JoystickFont.Families[0], 26);
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
                for (int i = 0; i < weapons.Count; i++)
                {
                    weapons[i].Size = new Size((this.Width / weapons.Count) - 30, this.Height - (btnStart.Height + 200));
                    weapons[i].Location = new Point((this.Width * i / weapons.Count) + 5, 10);
                }
            }
            catch
            {
            }
        }
        public void ChangePickedWeapon(int pickedIndex)
        {
            main.scanner = scanners[pickedIndex];
            btnStart.Enabled = true;
            for (int i = 0; i < weapons.Count; i++)
            {
                if(i != pickedIndex && weapons[i].isClicked)
                    weapons[i].WeaponShowCase_Click();
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Weapons_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var weapon in weapons) { weapon.TurnOffVid(); }
        }
    }
}