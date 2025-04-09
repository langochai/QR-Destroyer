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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameFrame));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.eleHost = new System.Windows.Forms.Integration.ElementHost();
            this.grvRank = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterestIds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChannelIds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlaytime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRanking = new System.Windows.Forms.Label();
            this.GameTick = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnActualPlay = new System.Windows.Forms.PictureBox();
            this.btnTrialPlay = new System.Windows.Forms.PictureBox();
            this.lblPlayTime = new System.Windows.Forms.Label();
            this.star6 = new System.Windows.Forms.PictureBox();
            this.star5 = new System.Windows.Forms.PictureBox();
            this.star4 = new System.Windows.Forms.PictureBox();
            this.star3 = new System.Windows.Forms.PictureBox();
            this.star2 = new System.Windows.Forms.PictureBox();
            this.star1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picSetting = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            ((System.ComponentModel.ISupportInitialize)(this.btnActualPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTrialPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSetting)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Location = new System.Drawing.Point(3, 433);
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
            this.splitContainer2.Size = new System.Drawing.Size(2558, 985);
            this.splitContainer2.SplitterDistance = 1986;
            this.splitContainer2.TabIndex = 3;
            // 
            // eleHost
            // 
            this.eleHost.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eleHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eleHost.Location = new System.Drawing.Point(0, 0);
            this.eleHost.Name = "eleHost";
            this.eleHost.Size = new System.Drawing.Size(1982, 981);
            this.eleHost.TabIndex = 0;
            this.eleHost.Text = "elementHost1";
            this.eleHost.Child = null;
            // 
            // grvRank
            // 
            this.grvRank.AllowUserToAddRows = false;
            this.grvRank.AllowUserToDeleteRows = false;
            this.grvRank.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvRank.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grvRank.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvRank.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grvRank.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvRank.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grvRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvRank.ColumnHeadersVisible = false;
            this.grvRank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colCompany,
            this.colEmail,
            this.colPhoneNumber,
            this.colCreatedDate,
            this.InterestIds,
            this.colChannelIds,
            this.colRank,
            this.colName,
            this.colPlaytime});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvRank.DefaultCellStyle = dataGridViewCellStyle6;
            this.grvRank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvRank.GridColor = System.Drawing.SystemColors.Window;
            this.grvRank.Location = new System.Drawing.Point(0, 55);
            this.grvRank.Name = "grvRank";
            this.grvRank.ReadOnly = true;
            this.grvRank.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvRank.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grvRank.RowHeadersVisible = false;
            this.grvRank.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.grvRank.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.grvRank.RowTemplate.Height = 60;
            this.grvRank.Size = new System.Drawing.Size(564, 926);
            this.grvRank.TabIndex = 1;
            this.grvRank.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvRank_CellClick);
            this.grvRank.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grvRank_CellFormatting);
            this.grvRank.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.grvRank_CellPainting);
            this.grvRank.SizeChanged += new System.EventHandler(this.grvRank_SizeChanged);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colCompany
            // 
            this.colCompany.DataPropertyName = "Company";
            this.colCompany.HeaderText = "Company";
            this.colCompany.Name = "colCompany";
            this.colCompany.ReadOnly = true;
            this.colCompany.Visible = false;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Visible = false;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.DataPropertyName = "PhoneNumber";
            this.colPhoneNumber.HeaderText = "PhoneNumber";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.ReadOnly = true;
            this.colPhoneNumber.Visible = false;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.DataPropertyName = "CreatedDate";
            this.colCreatedDate.HeaderText = "CreatedDate";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.ReadOnly = true;
            this.colCreatedDate.Visible = false;
            // 
            // InterestIds
            // 
            this.InterestIds.DataPropertyName = "InterestIds";
            this.InterestIds.HeaderText = "InterestIds";
            this.InterestIds.Name = "InterestIds";
            this.InterestIds.ReadOnly = true;
            this.InterestIds.Visible = false;
            // 
            // colChannelIds
            // 
            this.colChannelIds.DataPropertyName = "ChannelIds";
            this.colChannelIds.HeaderText = "ChannelIds";
            this.colChannelIds.Name = "colChannelIds";
            this.colChannelIds.ReadOnly = true;
            this.colChannelIds.Visible = false;
            // 
            // colRank
            // 
            this.colRank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRank.DataPropertyName = "Rank";
            this.colRank.FillWeight = 15F;
            this.colRank.HeaderText = "Rank";
            this.colRank.Name = "colRank";
            this.colRank.ReadOnly = true;
            this.colRank.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "FullName";
            this.colName.FillWeight = 68F;
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPlaytime
            // 
            this.colPlaytime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPlaytime.DataPropertyName = "PlayTime";
            this.colPlaytime.FillWeight = 17F;
            this.colPlaytime.HeaderText = "Playtime";
            this.colPlaytime.Name = "colPlaytime";
            this.colPlaytime.ReadOnly = true;
            this.colPlaytime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.lblRanking);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 55);
            this.panel2.TabIndex = 0;
            // 
            // lblRanking
            // 
            this.lblRanking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRanking.AutoSize = true;
            this.lblRanking.BackColor = System.Drawing.Color.Transparent;
            this.lblRanking.Font = new System.Drawing.Font("Joystix Monospace", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRanking.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblRanking.Location = new System.Drawing.Point(157, 7);
            this.lblRanking.Name = "lblRanking";
            this.lblRanking.Size = new System.Drawing.Size(259, 44);
            this.lblRanking.TabIndex = 0;
            this.lblRanking.Text = "Top rank";
            this.lblRanking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameTick
            // 
            this.GameTick.Interval = 1000;
            this.GameTick.Tick += new System.EventHandler(this.GameTick_Tick);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::wpf_in_winforms.Properties.Resources.Score_Background;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnActualPlay);
            this.panel3.Controls.Add(this.btnTrialPlay);
            this.panel3.Controls.Add(this.star6);
            this.panel3.Controls.Add(this.star5);
            this.panel3.Controls.Add(this.star4);
            this.panel3.Controls.Add(this.star3);
            this.panel3.Controls.Add(this.star2);
            this.panel3.Controls.Add(this.star1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 333);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2558, 94);
            this.panel3.TabIndex = 5;
            // 
            // btnActualPlay
            // 
            this.btnActualPlay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnActualPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnActualPlay.Image = global::wpf_in_winforms.Properties.Resources.play;
            this.btnActualPlay.Location = new System.Drawing.Point(2218, -1);
            this.btnActualPlay.Name = "btnActualPlay";
            this.btnActualPlay.Size = new System.Drawing.Size(162, 99);
            this.btnActualPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnActualPlay.TabIndex = 10;
            this.btnActualPlay.TabStop = false;
            this.btnActualPlay.Click += new System.EventHandler(this.btnActualPlay_Click);
            // 
            // btnTrialPlay
            // 
            this.btnTrialPlay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTrialPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnTrialPlay.Image = global::wpf_in_winforms.Properties.Resources.trial;
            this.btnTrialPlay.Location = new System.Drawing.Point(2386, -3);
            this.btnTrialPlay.Name = "btnTrialPlay";
            this.btnTrialPlay.Size = new System.Drawing.Size(162, 99);
            this.btnTrialPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTrialPlay.TabIndex = 9;
            this.btnTrialPlay.TabStop = false;
            this.btnTrialPlay.Click += new System.EventHandler(this.btnTrialPlay_Click);
            // 
            // lblPlayTime
            // 
            this.lblPlayTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPlayTime.AutoSize = true;
            this.lblPlayTime.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayTime.Font = new System.Drawing.Font("LCDMono2", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayTime.ForeColor = System.Drawing.Color.Red;
            this.lblPlayTime.Location = new System.Drawing.Point(22, 263);
            this.lblPlayTime.Name = "lblPlayTime";
            this.lblPlayTime.Size = new System.Drawing.Size(143, 42);
            this.lblPlayTime.TabIndex = 8;
            this.lblPlayTime.Text = "00:00";
            // 
            // star6
            // 
            this.star6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.star6.BackColor = System.Drawing.Color.Transparent;
            this.star6.Image = ((System.Drawing.Image)(resources.GetObject("star6.Image")));
            this.star6.Location = new System.Drawing.Point(1282, 3);
            this.star6.Name = "star6";
            this.star6.Size = new System.Drawing.Size(90, 90);
            this.star6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star6.TabIndex = 5;
            this.star6.TabStop = false;
            // 
            // star5
            // 
            this.star5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.star5.BackColor = System.Drawing.Color.Transparent;
            this.star5.Image = ((System.Drawing.Image)(resources.GetObject("star5.Image")));
            this.star5.Location = new System.Drawing.Point(1186, 3);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(90, 90);
            this.star5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star5.TabIndex = 4;
            this.star5.TabStop = false;
            // 
            // star4
            // 
            this.star4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.star4.BackColor = System.Drawing.Color.Transparent;
            this.star4.Image = ((System.Drawing.Image)(resources.GetObject("star4.Image")));
            this.star4.Location = new System.Drawing.Point(1090, 5);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(90, 90);
            this.star4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star4.TabIndex = 3;
            this.star4.TabStop = false;
            // 
            // star3
            // 
            this.star3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.star3.BackColor = System.Drawing.Color.Transparent;
            this.star3.Image = ((System.Drawing.Image)(resources.GetObject("star3.Image")));
            this.star3.Location = new System.Drawing.Point(994, 5);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(90, 90);
            this.star3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star3.TabIndex = 2;
            this.star3.TabStop = false;
            // 
            // star2
            // 
            this.star2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.star2.BackColor = System.Drawing.Color.Transparent;
            this.star2.Image = ((System.Drawing.Image)(resources.GetObject("star2.Image")));
            this.star2.Location = new System.Drawing.Point(898, 5);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(90, 90);
            this.star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star2.TabIndex = 1;
            this.star2.TabStop = false;
            // 
            // star1
            // 
            this.star1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.star1.BackColor = System.Drawing.Color.Transparent;
            this.star1.Image = ((System.Drawing.Image)(resources.GetObject("star1.Image")));
            this.star1.Location = new System.Drawing.Point(802, 3);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(90, 90);
            this.star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star1.TabIndex = 0;
            this.star1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::wpf_in_winforms.Properties.Resources.header_background;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.picSetting);
            this.panel1.Controls.Add(this.lblPlayTime);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2558, 324);
            this.panel1.TabIndex = 1;
            // 
            // picSetting
            // 
            this.picSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSetting.BackColor = System.Drawing.Color.Transparent;
            this.picSetting.Image = global::wpf_in_winforms.Properties.Resources.cog;
            this.picSetting.Location = new System.Drawing.Point(2523, 7);
            this.picSetting.Name = "picSetting";
            this.picSetting.Size = new System.Drawing.Size(30, 30);
            this.picSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSetting.TabIndex = 7;
            this.picSetting.TabStop = false;
            this.picSetting.Click += new System.EventHandler(this.picSetting_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2564, 1421);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // GameFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2564, 1421);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameFrame";
            this.Text = "RTC CODE HUNTING CHAMPION";
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
            ((System.ComponentModel.ISupportInitialize)(this.btnActualPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTrialPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSetting)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grvRank;
        private System.Windows.Forms.Label lblRanking;
        private System.Windows.Forms.Integration.ElementHost eleHost;
        private System.Windows.Forms.Timer GameTick;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPlayTime;
        private System.Windows.Forms.PictureBox picSetting;
        private System.Windows.Forms.PictureBox star6;
        private System.Windows.Forms.PictureBox star5;
        private System.Windows.Forms.PictureBox star4;
        private System.Windows.Forms.PictureBox star3;
        private System.Windows.Forms.PictureBox star2;
        private System.Windows.Forms.PictureBox star1;
        private System.Windows.Forms.PictureBox btnTrialPlay;
        private System.Windows.Forms.PictureBox btnActualPlay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterestIds;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChannelIds;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlaytime;
    }
}

