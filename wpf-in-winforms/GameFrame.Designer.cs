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
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInterestIds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChannelIds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.lblGameName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picSetting = new System.Windows.Forms.PictureBox();
            this.txtQRResult = new System.Windows.Forms.TextBox();
            this.star6 = new System.Windows.Forms.PictureBox();
            this.star5 = new System.Windows.Forms.PictureBox();
            this.star4 = new System.Windows.Forms.PictureBox();
            this.star3 = new System.Windows.Forms.PictureBox();
            this.star2 = new System.Windows.Forms.PictureBox();
            this.star1 = new System.Windows.Forms.PictureBox();
            this.GameTick = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvRank)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.splitContainer2.Location = new System.Drawing.Point(0, 205);
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
            this.splitContainer2.Size = new System.Drawing.Size(1584, 656);
            this.splitContainer2.SplitterDistance = 1220;
            this.splitContainer2.TabIndex = 3;
            // 
            // eleHost
            // 
            this.eleHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eleHost.Location = new System.Drawing.Point(0, 0);
            this.eleHost.Name = "eleHost";
            this.eleHost.Size = new System.Drawing.Size(1216, 652);
            this.eleHost.TabIndex = 0;
            this.eleHost.Text = "elementHost1";
            this.eleHost.Child = null;
            // 
            // grvRank
            // 
            this.grvRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvRank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colRank,
            this.colName,
            this.colEmail,
            this.colPhoneNumber,
            this.colInterestIds,
            this.colChannelIds,
            this.colCompany,
            this.colPlayTime,
            this.colCreatedDate});
            this.grvRank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvRank.Location = new System.Drawing.Point(0, 100);
            this.grvRank.Name = "grvRank";
            this.grvRank.Size = new System.Drawing.Size(356, 552);
            this.grvRank.TabIndex = 1;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colRank
            // 
            this.colRank.HeaderText = "Rank";
            this.colRank.Name = "colRank";
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = false;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.DataPropertyName = "PhoneNumber";
            this.colPhoneNumber.HeaderText = "PhoneNumber";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.Visible = false;
            // 
            // colInterestIds
            // 
            this.colInterestIds.DataPropertyName = "InterestIds";
            this.colInterestIds.HeaderText = "InterestIds";
            this.colInterestIds.Name = "colInterestIds";
            this.colInterestIds.Visible = false;
            // 
            // colChannelIds
            // 
            this.colChannelIds.DataPropertyName = "ChannelIds";
            this.colChannelIds.HeaderText = "ChannelIds";
            this.colChannelIds.Name = "colChannelIds";
            this.colChannelIds.Visible = false;
            // 
            // colCompany
            // 
            this.colCompany.DataPropertyName = "Company";
            this.colCompany.HeaderText = "Company";
            this.colCompany.Name = "colCompany";
            this.colCompany.Visible = false;
            // 
            // colPlayTime
            // 
            this.colPlayTime.DataPropertyName = "PlayTime";
            this.colPlayTime.HeaderText = "PlayTime";
            this.colPlayTime.Name = "colPlayTime";
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.DataPropertyName = "CreatedDate";
            this.colCreatedDate.HeaderText = "CreatedDate";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 100);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Xếp hạng";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackgroundImage = global::wpf_in_winforms.Properties.Resources.icon_logo_RTC_2023;
            this.splitContainer3.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.lblGameName);
            this.splitContainer3.Size = new System.Drawing.Size(1584, 100);
            this.splitContainer3.SplitterDistance = 100;
            this.splitContainer3.TabIndex = 0;
            // 
            // lblGameName
            // 
            this.lblGameName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGameName.AutoSize = true;
            this.lblGameName.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.Location = new System.Drawing.Point(430, 22);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(424, 55);
            this.lblGameName.TabIndex = 0;
            this.lblGameName.Text = "QR DESTROYER!";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.picSetting);
            this.panel1.Controls.Add(this.txtQRResult);
            this.panel1.Controls.Add(this.star6);
            this.panel1.Controls.Add(this.star5);
            this.panel1.Controls.Add(this.star4);
            this.panel1.Controls.Add(this.star3);
            this.panel1.Controls.Add(this.star2);
            this.panel1.Controls.Add(this.star1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1584, 105);
            this.panel1.TabIndex = 4;
            // 
            // picSetting
            // 
            this.picSetting.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picSetting.Image = global::wpf_in_winforms.Properties.Resources.cog;
            this.picSetting.Location = new System.Drawing.Point(1482, 19);
            this.picSetting.Name = "picSetting";
            this.picSetting.Size = new System.Drawing.Size(65, 65);
            this.picSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSetting.TabIndex = 7;
            this.picSetting.TabStop = false;
            this.picSetting.Click += new System.EventHandler(this.picSetting_Click);
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
            this.star6.Image = global::wpf_in_winforms.Properties.Resources.star_disable;
            this.star6.Location = new System.Drawing.Point(927, 19);
            this.star6.Name = "star6";
            this.star6.Size = new System.Drawing.Size(65, 65);
            this.star6.TabIndex = 5;
            this.star6.TabStop = false;
            // 
            // star5
            // 
            this.star5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.star5.Image = global::wpf_in_winforms.Properties.Resources.star_disable;
            this.star5.Location = new System.Drawing.Point(856, 19);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(65, 65);
            this.star5.TabIndex = 4;
            this.star5.TabStop = false;
            // 
            // star4
            // 
            this.star4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.star4.Image = global::wpf_in_winforms.Properties.Resources.star_disable;
            this.star4.Location = new System.Drawing.Point(785, 19);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(65, 65);
            this.star4.TabIndex = 3;
            this.star4.TabStop = false;
            // 
            // star3
            // 
            this.star3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.star3.Image = global::wpf_in_winforms.Properties.Resources.star_disable;
            this.star3.Location = new System.Drawing.Point(714, 19);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(65, 65);
            this.star3.TabIndex = 2;
            this.star3.TabStop = false;
            // 
            // star2
            // 
            this.star2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.star2.Image = global::wpf_in_winforms.Properties.Resources.star_disable;
            this.star2.Location = new System.Drawing.Point(643, 19);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(65, 65);
            this.star2.TabIndex = 1;
            this.star2.TabStop = false;
            // 
            // star1
            // 
            this.star1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.star1.Image = global::wpf_in_winforms.Properties.Resources.star_disable;
            this.star1.Location = new System.Drawing.Point(572, 19);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(65, 65);
            this.star1.TabIndex = 0;
            this.star1.TabStop = false;
            // 
            // GameTick
            // 
            this.GameTick.Interval = 1000;
            // 
            // GameFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameFrame";
            this.Text = "QR DESTROYER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox star6;
        private System.Windows.Forms.PictureBox star5;
        private System.Windows.Forms.PictureBox star4;
        private System.Windows.Forms.PictureBox star3;
        private System.Windows.Forms.PictureBox star2;
        private System.Windows.Forms.PictureBox star1;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Integration.ElementHost eleHost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInterestIds;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChannelIds;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlayTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedDate;
        private System.Windows.Forms.TextBox txtQRResult;
        private System.Windows.Forms.PictureBox picSetting;
        private System.Windows.Forms.Timer GameTick;
    }
}

