namespace wpf_in_winforms.Forms
{
    partial class Victory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Victory));
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.lblAnnounce = new System.Windows.Forms.Label();
            this.lblPlaytime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // picBackground
            // 
            this.picBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBackground.Image = global::wpf_in_winforms.Properties.Resources.victory;
            this.picBackground.Location = new System.Drawing.Point(0, 0);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(1024, 762);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 0;
            this.picBackground.TabStop = false;
            // 
            // lblAnnounce
            // 
            this.lblAnnounce.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnnounce.BackColor = System.Drawing.Color.Transparent;
            this.lblAnnounce.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnounce.ForeColor = System.Drawing.Color.White;
            this.lblAnnounce.Location = new System.Drawing.Point(117, 533);
            this.lblAnnounce.Name = "lblAnnounce";
            this.lblAnnounce.Size = new System.Drawing.Size(805, 224);
            this.lblAnnounce.TabIndex = 1;
            this.lblAnnounce.Text = "Bạn là người chiến thắng";
            this.lblAnnounce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlaytime
            // 
            this.lblPlaytime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlaytime.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaytime.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaytime.ForeColor = System.Drawing.Color.White;
            this.lblPlaytime.Location = new System.Drawing.Point(117, 4);
            this.lblPlaytime.Name = "lblPlaytime";
            this.lblPlaytime.Size = new System.Drawing.Size(805, 198);
            this.lblPlaytime.TabIndex = 2;
            this.lblPlaytime.Text = "Bạn là người chiến thắng";
            this.lblPlaytime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Victory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 762);
            this.Controls.Add(this.lblPlaytime);
            this.Controls.Add(this.lblAnnounce);
            this.Controls.Add(this.picBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Victory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Victory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Victory_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.Label lblAnnounce;
        private System.Windows.Forms.Label lblPlaytime;
    }
}