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
            this.lblHeader = new System.Windows.Forms.Label();
            this.weaponShowCase1 = new wpf_in_winforms.UC.WeaponShowCase();
            this.weaponShowCase2 = new wpf_in_winforms.UC.WeaponShowCase();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Joystix Monospace", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(581, 44);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1417, 115);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "CHOOSE YOUR WEAPON";
            // 
            // weaponShowCase1
            // 
            this.weaponShowCase1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.weaponShowCase1.BackColor = System.Drawing.Color.Transparent;
            this.weaponShowCase1.Location = new System.Drawing.Point(456, 254);
            this.weaponShowCase1.Name = "weaponShowCase1";
            this.weaponShowCase1.Size = new System.Drawing.Size(695, 976);
            this.weaponShowCase1.TabIndex = 1;
            this.weaponShowCase1.WeaponImage = global::wpf_in_winforms.Properties.Resources.wp2;
            this.weaponShowCase1.WeaponIndex = 1;
            // 
            // weaponShowCase2
            // 
            this.weaponShowCase2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.weaponShowCase2.BackColor = System.Drawing.Color.Transparent;
            this.weaponShowCase2.Location = new System.Drawing.Point(1407, 254);
            this.weaponShowCase2.Name = "weaponShowCase2";
            this.weaponShowCase2.Size = new System.Drawing.Size(695, 976);
            this.weaponShowCase2.TabIndex = 0;
            this.weaponShowCase2.WeaponImage = global::wpf_in_winforms.Properties.Resources.wp1;
            this.weaponShowCase2.WeaponIndex = 0;
            // 
            // Weapons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2564, 1421);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.weaponShowCase1);
            this.Controls.Add(this.weaponShowCase2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Weapons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weapons";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC.WeaponShowCase weaponShowCase2;
        private UC.WeaponShowCase weaponShowCase1;
        private System.Windows.Forms.Label lblHeader;
    }
}