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
            this.lblDescription = new System.Windows.Forms.Label();
            this.picAbout = new System.Windows.Forms.PictureBox();
            this.vidAbout = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(3, 75);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(485, 66);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Some place holder texts to see if the description can be fit in the screen withou" +
    "t additional adjustment";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // picAbout
            // 
            this.picAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picAbout.Location = new System.Drawing.Point(3, 155);
            this.picAbout.Name = "picAbout";
            this.picAbout.Size = new System.Drawing.Size(485, 441);
            this.picAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAbout.TabIndex = 8;
            this.picAbout.TabStop = false;
            this.picAbout.Click += new System.EventHandler(this.picAbout_Click);
            // 
            // vidAbout
            // 
            this.vidAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vidAbout.Enabled = true;
            this.vidAbout.Location = new System.Drawing.Point(3, 155);
            this.vidAbout.Name = "vidAbout";
            this.vidAbout.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("vidAbout.OcxState")));
            this.vidAbout.Size = new System.Drawing.Size(485, 441);
            this.vidAbout.TabIndex = 9;
            this.vidAbout.Visible = false;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.Font = new System.Drawing.Font("Joystix Monospace", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(7, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(481, 57);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên vũ khí";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // WeaponShowCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vidAbout);
            this.Controls.Add(this.picAbout);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.DoubleBuffered = true;
            this.Name = "WeaponShowCase";
            this.Size = new System.Drawing.Size(491, 612);
            this.Click += new System.EventHandler(this.WeaponShowCase_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidAbout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox picAbout;
        private AxWMPLib.AxWindowsMediaPlayer vidAbout;
        private System.Windows.Forms.Label lblName;
    }
}
