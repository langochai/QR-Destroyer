namespace wpf_in_winforms.Forms
{
    partial class Weapons
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Weapons));
            this.weaponShowCase1 = new wpf_in_winforms.UC.WeaponShowCase();
            this.weaponShowCase2 = new wpf_in_winforms.UC.WeaponShowCase();
            this.SuspendLayout();
            // 
            // weaponShowCase1
            // 
            this.weaponShowCase1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.weaponShowCase1.BackColor = System.Drawing.Color.Transparent;
            this.weaponShowCase1.Location = new System.Drawing.Point(385, 140);
            this.weaponShowCase1.Name = "weaponShowCase1";
            this.weaponShowCase1.Size = new System.Drawing.Size(743, 1090);
            this.weaponShowCase1.TabIndex = 1;
            this.weaponShowCase1.WeaponImage = global::wpf_in_winforms.Properties.Resources.wp2;
            this.weaponShowCase1.WeaponIndex = 1;
            // 
            // weaponShowCase2
            // 
            this.weaponShowCase2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.weaponShowCase2.BackColor = System.Drawing.Color.Transparent;
            this.weaponShowCase2.Location = new System.Drawing.Point(1386, 140);
            this.weaponShowCase2.Name = "weaponShowCase2";
            this.weaponShowCase2.Size = new System.Drawing.Size(743, 1090);
            this.weaponShowCase2.TabIndex = 0;
            this.weaponShowCase2.WeaponImage = global::wpf_in_winforms.Properties.Resources.wp1;
            this.weaponShowCase2.WeaponIndex = 0;
            // 
            // Weapons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2564, 1421);
            this.Controls.Add(this.weaponShowCase1);
            this.Controls.Add(this.weaponShowCase2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Weapons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weapons";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private UC.WeaponShowCase weaponShowCase2;
        private UC.WeaponShowCase weaponShowCase1;
    }
}