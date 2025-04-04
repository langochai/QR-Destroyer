namespace wpf_in_winforms.UC
{
    partial class WeaponShowCase
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picWeapon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWeapon)).BeginInit();
            this.SuspendLayout();
            // 
            // picWeapon
            // 
            this.picWeapon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picWeapon.Location = new System.Drawing.Point(0, 0);
            this.picWeapon.Name = "picWeapon";
            this.picWeapon.Size = new System.Drawing.Size(491, 612);
            this.picWeapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWeapon.TabIndex = 0;
            this.picWeapon.TabStop = false;
            // 
            // WeaponShowCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.picWeapon);
            this.DoubleBuffered = true;
            this.Name = "WeaponShowCase";
            this.Size = new System.Drawing.Size(491, 612);
            this.Click += new System.EventHandler(this.WeaponShowCase_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WeaponShowCase_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picWeapon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picWeapon;
    }
}
