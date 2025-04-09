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
        private readonly FrmMainNew main;
        private List<Scanner> scanners;
        private List<WeaponShowCase> weapons = new List<WeaponShowCase>();

        public Weapons(FrmMainNew m)
        {
            InitializeComponent();
            lblHeader.Font = new Font(FontRegister.JoystickFont.Families[0], 72);
            this.main = m;
            try
            {
                scanners = GetScanners();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            weaponShowCase1.picWeapon.Click += PicWeapon_Click1;
            weaponShowCase2.picWeapon.Click += PicWeapon_Click2;
        }

        private void PicWeapon_Click1(object sender, EventArgs e)
        {
            WeaponDetails wpd = new WeaponDetails(scanners[0]);
            this.Hide();
            var result = wpd.ShowDialog();
            if (result != DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                main.scanner = scanners[0];
                this.DialogResult = DialogResult.OK;
            }
        }

        private void PicWeapon_Click2(object sender, EventArgs e)
        {
            WeaponDetails wpd = new WeaponDetails(scanners[1]);
            this.Hide();
            var result = wpd.ShowDialog();
            if (result != DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                main.scanner = scanners[1];
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
    }
}