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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeaponShowCase));
            this.picAbout = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.vidAbout = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // picAbout
            // 
            this.picAbout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picAbout.Location = new System.Drawing.Point(28, 120);
            this.picAbout.Name = "picAbout";
            this.picAbout.Size = new System.Drawing.Size(435, 396);
            this.picAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAbout.TabIndex = 8;
            this.picAbout.TabStop = false;
            this.picAbout.Click += new System.EventHandler(this.picAbout_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.Font = new System.Drawing.Font("Joystix Monospace", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(7, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(481, 89);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên vũ khí";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picLogo.Location = new System.Drawing.Point(95, 522);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(301, 78);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 10;
            this.picLogo.TabStop = false;
            // 
            // vidAbout
            // 
            this.vidAbout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vidAbout.Enabled = true;
            this.vidAbout.Location = new System.Drawing.Point(28, 120);
            this.vidAbout.Name = "vidAbout";
            this.vidAbout.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("vidAbout.OcxState")));
            this.vidAbout.Size = new System.Drawing.Size(435, 396);
            this.vidAbout.TabIndex = 9;
            this.vidAbout.Visible = false;
            // 
            // WeaponShowCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.vidAbout);
            this.Controls.Add(this.picAbout);
            this.Controls.Add(this.lblName);
            this.DoubleBuffered = true;
            this.Name = "WeaponShowCase";
            this.Size = new System.Drawing.Size(491, 612);
            this.Click += new System.EventHandler(this.WeaponShowCase_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WeaponShowCase_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidAbout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picAbout;
        private AxWMPLib.AxWindowsMediaPlayer vidAbout;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picLogo;
    }
}
