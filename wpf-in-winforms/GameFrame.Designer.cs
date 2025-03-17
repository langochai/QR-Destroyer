namespace wpf_in_winforms
{
    partial class GameFrame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameFrame));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.eleHost = new System.Windows.Forms.Integration.ElementHost();
            this.grvRank = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.GameTick = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPlayTime = new System.Windows.Forms.Label();
            this.picSetting = new System.Windows.Forms.PictureBox();
            this.txtQRResult = new System.Windows.Forms.TextBox();
            this.star6 = new System.Windows.Forms.PictureBox();
            this.star5 = new System.Windows.Forms.PictureBox();
            this.star4 = new System.Windows.Forms.PictureBox();
            this.star3 = new System.Windows.Forms.PictureBox();
            this.star2 = new System.Windows.Forms.PictureBox();
            this.star1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvRank)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = global::wpf_in_winforms.Properties.Resources.icon_logo_RTC_2023;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1850, 101);
            this.splitContainer1.SplitterDistance = 121;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "QR DESTROYER!";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 285);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.eleHost);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.grvRank);
            this.splitContainer2.Panel2.Controls.Add(this.panel2);
            this.splitContainer2.Size = new System.Drawing.Size(1584, 576);
            this.splitContainer2.SplitterDistance = 1231;
            this.splitContainer2.TabIndex = 3;
            // 
            // eleHost
            // 
            this.eleHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eleHost.Location = new System.Drawing.Point(0, 0);
            this.eleHost.Name = "eleHost";
            this.eleHost.Size = new System.Drawing.Size(1227, 572);
            this.eleHost.TabIndex = 0;
            this.eleHost.Text = "elementHost1";
            this.eleHost.Child = null;
            // 
            // grvRank
            // 
            this.grvRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvRank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvRank.Location = new System.Drawing.Point(0, 100);
            this.grvRank.Name = "grvRank";
            this.grvRank.Size = new System.Drawing.Size(345, 472);
            this.grvRank.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 100);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 74);
            this.label2.TabIndex = 0;
            this.label2.Text = "Top những người\r\nnguy hiểm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameTick
            // 
            this.GameTick.Interval = 1000;
            this.GameTick.Tick += new System.EventHandler(this.GameTick_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::wpf_in_winforms.Properties.Resources.Header_Image;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1584, 180);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::wpf_in_winforms.Properties.Resources.Score_Background;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblPlayTime);
            this.panel3.Controls.Add(this.picSetting);
            this.panel3.Controls.Add(this.txtQRResult);
            this.panel3.Controls.Add(this.star6);
            this.panel3.Controls.Add(this.star5);
            this.panel3.Controls.Add(this.star4);
            this.panel3.Controls.Add(this.star3);
            this.panel3.Controls.Add(this.star2);
            this.panel3.Controls.Add(this.star1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1584, 105);
            this.panel3.TabIndex = 5;
            // 
            // lblPlayTime
            // 
            this.lblPlayTime.AutoSize = true;
            this.lblPlayTime.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayTime.Location = new System.Drawing.Point(29, 39);
            this.lblPlayTime.Name = "lblPlayTime";
            this.lblPlayTime.Size = new System.Drawing.Size(64, 24);
            this.lblPlayTime.TabIndex = 8;
            this.lblPlayTime.Text = "00:00";
            // 
            // picSetting
            // 
            this.picSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSetting.BackColor = System.Drawing.Color.Transparent;
            this.picSetting.Image = global::wpf_in_winforms.Properties.Resources.cog;
            this.picSetting.Location = new System.Drawing.Point(1482, 19);
            this.picSetting.Name = "picSetting";
            this.picSetting.Size = new System.Drawing.Size(65, 65);
            this.picSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSetting.TabIndex = 7;
            this.picSetting.TabStop = false;
            // 
            // txtQRResult
            // 
            this.txtQRResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQRResult.Location = new System.Drawing.Point(1344, 42);
            this.txtQRResult.Name = "txtQRResult";
            this.txtQRResult.Size = new System.Drawing.Size(100, 20);
            this.txtQRResult.TabIndex = 6;
            // 
            // star6
            // 
            this.star6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.star6.BackColor = System.Drawing.Color.Transparent;
            this.star6.Image = ((System.Drawing.Image)(resources.GetObject("star6.Image")));
            this.star6.Location = new System.Drawing.Point(927, 19);
            this.star6.Name = "star6";
            this.star6.Size = new System.Drawing.Size(65, 65);
            this.star6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star6.TabIndex = 5;
            this.star6.TabStop = false;
            // 
            // star5
            // 
            this.star5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.star5.BackColor = System.Drawing.Color.Transparent;
            this.star5.Image = ((System.Drawing.Image)(resources.GetObject("star5.Image")));
            this.star5.Location = new System.Drawing.Point(856, 19);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(65, 65);
            this.star5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star5.TabIndex = 4;
            this.star5.TabStop = false;
            // 
            // star4
            // 
            this.star4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.star4.BackColor = System.Drawing.Color.Transparent;
            this.star4.Image = ((System.Drawing.Image)(resources.GetObject("star4.Image")));
            this.star4.Location = new System.Drawing.Point(785, 19);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(65, 65);
            this.star4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star4.TabIndex = 3;
            this.star4.TabStop = false;
            // 
            // star3
            // 
            this.star3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.star3.BackColor = System.Drawing.Color.Transparent;
            this.star3.Image = ((System.Drawing.Image)(resources.GetObject("star3.Image")));
            this.star3.Location = new System.Drawing.Point(714, 19);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(65, 65);
            this.star3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star3.TabIndex = 2;
            this.star3.TabStop = false;
            // 
            // star2
            // 
            this.star2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.star2.BackColor = System.Drawing.Color.Transparent;
            this.star2.Image = ((System.Drawing.Image)(resources.GetObject("star2.Image")));
            this.star2.Location = new System.Drawing.Point(643, 19);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(65, 65);
            this.star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star2.TabIndex = 1;
            this.star2.TabStop = false;
            // 
            // star1
            // 
            this.star1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.star1.BackColor = System.Drawing.Color.Transparent;
            this.star1.Image = ((System.Drawing.Image)(resources.GetObject("star1.Image")));
            this.star1.Location = new System.Drawing.Point(572, 19);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(65, 65);
            this.star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star1.TabIndex = 0;
            this.star1.TabStop = false;
            // 
            // GameFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameFrame";
            this.Text = "QR DESTROYER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GameFrame_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvRank)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grvRank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Integration.ElementHost eleHost;
        private System.Windows.Forms.Timer GameTick;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPlayTime;
        private System.Windows.Forms.PictureBox picSetting;
        private System.Windows.Forms.TextBox txtQRResult;
        private System.Windows.Forms.PictureBox star6;
        private System.Windows.Forms.PictureBox star5;
        private System.Windows.Forms.PictureBox star4;
        private System.Windows.Forms.PictureBox star3;
        private System.Windows.Forms.PictureBox star2;
        private System.Windows.Forms.PictureBox star1;
    }
}

