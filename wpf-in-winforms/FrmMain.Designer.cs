﻿namespace wpf_in_winforms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chkInterest7 = new System.Windows.Forms.CheckBox();
            this.chkInterest6 = new System.Windows.Forms.CheckBox();
            this.chkInterest5 = new System.Windows.Forms.CheckBox();
            this.chkInterest4 = new System.Windows.Forms.CheckBox();
            this.chkInterest3 = new System.Windows.Forms.CheckBox();
            this.chkInterest2 = new System.Windows.Forms.CheckBox();
            this.chkInterest1 = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chkChannel5 = new System.Windows.Forms.CheckBox();
            this.chkChannel4 = new System.Windows.Forms.CheckBox();
            this.chkChannel3 = new System.Windows.Forms.CheckBox();
            this.chkChannel2 = new System.Windows.Forms.CheckBox();
            this.chkChannel1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tblLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayout
            // 
            this.tblLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayout.BackColor = System.Drawing.Color.Transparent;
            this.tblLayout.ColumnCount = 4;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tblLayout.Controls.Add(this.panel1, 1, 0);
            this.tblLayout.Controls.Add(this.panel2, 2, 0);
            this.tblLayout.Controls.Add(this.panel3, 1, 1);
            this.tblLayout.Controls.Add(this.panel4, 2, 1);
            this.tblLayout.Location = new System.Drawing.Point(12, 106);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.RowCount = 2;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.87805F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.12195F));
            this.tblLayout.Size = new System.Drawing.Size(1447, 610);
            this.tblLayout.TabIndex = 52;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(89, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 145);
            this.panel1.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(165, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(460, 35);
            this.txtName.TabIndex = 50;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(5, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(118, 35);
            this.lblName.TabIndex = 51;
            this.lblName.Text = "Họ tên:";
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(9, 62);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(95, 35);
            this.lblEmail.TabIndex = 49;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(165, 67);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(460, 35);
            this.txtEmail.TabIndex = 48;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lblCompany);
            this.panel2.Controls.Add(this.txtCompany);
            this.panel2.Controls.Add(this.lblPhoneNumber);
            this.panel2.Controls.Add(this.txtPhoneNumber);
            this.panel2.Location = new System.Drawing.Point(725, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(630, 145);
            this.panel2.TabIndex = 1;
            // 
            // lblCompany
            // 
            this.lblCompany.BackColor = System.Drawing.Color.Transparent;
            this.lblCompany.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(13, 67);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(134, 40);
            this.lblCompany.TabIndex = 35;
            this.lblCompany.Text = "Công ty:";
            // 
            // txtCompany
            // 
            this.txtCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompany.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompany.Location = new System.Drawing.Point(164, 72);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(460, 35);
            this.txtCompany.TabIndex = 33;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(13, 6);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(95, 35);
            this.lblPhoneNumber.TabIndex = 34;
            this.lblPhoneNumber.Text = "SĐT:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(164, 11);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(460, 35);
            this.txtPhoneNumber.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.chkInterest7);
            this.panel3.Controls.Add(this.chkInterest6);
            this.panel3.Controls.Add(this.chkInterest5);
            this.panel3.Controls.Add(this.chkInterest4);
            this.panel3.Controls.Add(this.chkInterest3);
            this.panel3.Controls.Add(this.chkInterest2);
            this.panel3.Controls.Add(this.chkInterest1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(89, 154);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(630, 453);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 116);
            this.label1.TabIndex = 41;
            this.label1.Text = "Bạn đang muốn tìm hiểu và quan tâm giải pháp gì?/What solutions do you want to le" +
    "arn and are interested in?";
            // 
            // chkInterest7
            // 
            this.chkInterest7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkInterest7.AutoSize = true;
            this.chkInterest7.BackColor = System.Drawing.Color.Transparent;
            this.chkInterest7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInterest7.Location = new System.Drawing.Point(16, 408);
            this.chkInterest7.Name = "chkInterest7";
            this.chkInterest7.Size = new System.Drawing.Size(127, 29);
            this.chkInterest7.TabIndex = 48;
            this.chkInterest7.Text = "Khác/Other";
            this.chkInterest7.UseVisualStyleBackColor = false;
            // 
            // chkInterest6
            // 
            this.chkInterest6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkInterest6.AutoSize = true;
            this.chkInterest6.BackColor = System.Drawing.Color.Transparent;
            this.chkInterest6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInterest6.Location = new System.Drawing.Point(16, 377);
            this.chkInterest6.Name = "chkInterest6";
            this.chkInterest6.Size = new System.Drawing.Size(354, 29);
            this.chkInterest6.TabIndex = 47;
            this.chkInterest6.Text = "IoT, OEE, SCADA, E-Factory, E-Logistics";
            this.chkInterest6.UseVisualStyleBackColor = false;
            // 
            // chkInterest5
            // 
            this.chkInterest5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkInterest5.AutoSize = true;
            this.chkInterest5.BackColor = System.Drawing.Color.Transparent;
            this.chkInterest5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInterest5.Location = new System.Drawing.Point(16, 325);
            this.chkInterest5.Name = "chkInterest5";
            this.chkInterest5.Size = new System.Drawing.Size(535, 54);
            this.chkInterest5.TabIndex = 46;
            this.chkInterest5.Text = "Thiết bị tự động hoá trong sản xuất/Automation Equipment \r\nin Production";
            this.chkInterest5.UseVisualStyleBackColor = false;
            // 
            // chkInterest4
            // 
            this.chkInterest4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkInterest4.BackColor = System.Drawing.Color.Transparent;
            this.chkInterest4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInterest4.Location = new System.Drawing.Point(16, 271);
            this.chkInterest4.Name = "chkInterest4";
            this.chkInterest4.Size = new System.Drawing.Size(598, 54);
            this.chkInterest4.TabIndex = 45;
            this.chkInterest4.Text = "Giải pháp chế tạo máy tự động/\r\nAutomatic Machine Manufacturing Solutions";
            this.chkInterest4.UseVisualStyleBackColor = false;
            // 
            // chkInterest3
            // 
            this.chkInterest3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkInterest3.AutoSize = true;
            this.chkInterest3.BackColor = System.Drawing.Color.Transparent;
            this.chkInterest3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInterest3.Location = new System.Drawing.Point(16, 241);
            this.chkInterest3.Name = "chkInterest3";
            this.chkInterest3.Size = new System.Drawing.Size(380, 29);
            this.chkInterest3.TabIndex = 44;
            this.chkInterest3.Text = "Giải pháp AGV/AMR/ AGV/AMR Solutions";
            this.chkInterest3.UseVisualStyleBackColor = false;
            // 
            // chkInterest2
            // 
            this.chkInterest2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkInterest2.AutoSize = true;
            this.chkInterest2.BackColor = System.Drawing.Color.Transparent;
            this.chkInterest2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInterest2.Location = new System.Drawing.Point(16, 184);
            this.chkInterest2.Name = "chkInterest2";
            this.chkInterest2.Size = new System.Drawing.Size(481, 54);
            this.chkInterest2.TabIndex = 43;
            this.chkInterest2.Text = "Giải pháp xử lý ảnh công nghiệp Machine Vision/\r\nMachine Vision Industrial Image " +
    "Processing Solutions";
            this.chkInterest2.UseVisualStyleBackColor = false;
            // 
            // chkInterest1
            // 
            this.chkInterest1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkInterest1.AutoSize = true;
            this.chkInterest1.BackColor = System.Drawing.Color.Transparent;
            this.chkInterest1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInterest1.Location = new System.Drawing.Point(16, 152);
            this.chkInterest1.Name = "chkInterest1";
            this.chkInterest1.Size = new System.Drawing.Size(557, 29);
            this.chkInterest1.TabIndex = 42;
            this.chkInterest1.Text = "Giải pháp quản lý kho thông minh/Smart Warehouse Solutions";
            this.chkInterest1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chkChannel5);
            this.panel4.Controls.Add(this.chkChannel4);
            this.panel4.Controls.Add(this.chkChannel3);
            this.panel4.Controls.Add(this.chkChannel2);
            this.panel4.Controls.Add(this.chkChannel1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(725, 154);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(630, 453);
            this.panel4.TabIndex = 3;
            // 
            // chkChannel5
            // 
            this.chkChannel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkChannel5.AutoSize = true;
            this.chkChannel5.BackColor = System.Drawing.Color.Transparent;
            this.chkChannel5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChannel5.Location = new System.Drawing.Point(20, 343);
            this.chkChannel5.Name = "chkChannel5";
            this.chkChannel5.Size = new System.Drawing.Size(127, 29);
            this.chkChannel5.TabIndex = 51;
            this.chkChannel5.Text = "Khác/Other";
            this.chkChannel5.UseVisualStyleBackColor = false;
            // 
            // chkChannel4
            // 
            this.chkChannel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkChannel4.AutoSize = true;
            this.chkChannel4.BackColor = System.Drawing.Color.Transparent;
            this.chkChannel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChannel4.Location = new System.Drawing.Point(20, 283);
            this.chkChannel4.Name = "chkChannel4";
            this.chkChannel4.Size = new System.Drawing.Size(331, 54);
            this.chkChannel4.TabIndex = 50;
            this.chkChannel4.Text = "Đối tác, Bạn bè giới thiệu/\r\nPartners and Friends introduced me";
            this.chkChannel4.UseVisualStyleBackColor = false;
            // 
            // chkChannel3
            // 
            this.chkChannel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkChannel3.AutoSize = true;
            this.chkChannel3.BackColor = System.Drawing.Color.Transparent;
            this.chkChannel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChannel3.Location = new System.Drawing.Point(20, 248);
            this.chkChannel3.Name = "chkChannel3";
            this.chkChannel3.Size = new System.Drawing.Size(110, 29);
            this.chkChannel3.TabIndex = 49;
            this.chkChannel3.Text = "Facebook";
            this.chkChannel3.UseVisualStyleBackColor = false;
            // 
            // chkChannel2
            // 
            this.chkChannel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkChannel2.AutoSize = true;
            this.chkChannel2.BackColor = System.Drawing.Color.Transparent;
            this.chkChannel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChannel2.Location = new System.Drawing.Point(20, 213);
            this.chkChannel2.Name = "chkChannel2";
            this.chkChannel2.Size = new System.Drawing.Size(262, 29);
            this.chkChannel2.TabIndex = 48;
            this.chkChannel2.Text = "Qua kênh website / website";
            this.chkChannel2.UseVisualStyleBackColor = false;
            // 
            // chkChannel1
            // 
            this.chkChannel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkChannel1.AutoSize = true;
            this.chkChannel1.BackColor = System.Drawing.Color.Transparent;
            this.chkChannel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChannel1.Location = new System.Drawing.Point(20, 153);
            this.chkChannel1.Name = "chkChannel1";
            this.chkChannel1.Size = new System.Drawing.Size(315, 54);
            this.chkChannel1.TabIndex = 47;
            this.chkChannel1.Text = "Tôi nhận được thư mời qua email/\r\nI received an invitation via email?";
            this.chkChannel1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(609, 125);
            this.label2.TabIndex = 46;
            this.label2.Text = "Bạn biết tới sự kiện RTC Technology Việt Nam tham gia VIMF 2025 qua kênh nào?/Thr" +
    "ough which channel did you know about RTC Technology Vietnam\'s participation in " +
    "VIMF2025?";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = global::wpf_in_winforms.Properties.Resources.start_button;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.Location = new System.Drawing.Point(550, 722);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(376, 119);
            this.btnStart.TabIndex = 53;
            this.btnStart.TabStop = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1486, 100);
            this.pnlHeader.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1480, 82);
            this.label3.TabIndex = 0;
            this.label3.Text = "ĐĂNG KÝ THAM GIA TRÒ CHƠI";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::wpf_in_winforms.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1486, 858);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tblLayout);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tblLayout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tblLayout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox chkInterest7;
        private System.Windows.Forms.CheckBox chkInterest6;
        private System.Windows.Forms.CheckBox chkInterest5;
        private System.Windows.Forms.CheckBox chkInterest4;
        private System.Windows.Forms.CheckBox chkInterest3;
        private System.Windows.Forms.CheckBox chkInterest2;
        private System.Windows.Forms.CheckBox chkInterest1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkChannel5;
        private System.Windows.Forms.CheckBox chkChannel4;
        private System.Windows.Forms.CheckBox chkChannel3;
        private System.Windows.Forms.CheckBox chkChannel2;
        private System.Windows.Forms.CheckBox chkChannel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnStart;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label3;
    }
}