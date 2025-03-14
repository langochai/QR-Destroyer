namespace wpf_in_winforms
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkInterest1 = new System.Windows.Forms.CheckBox();
            this.chkInterest2 = new System.Windows.Forms.CheckBox();
            this.chkInterest3 = new System.Windows.Forms.CheckBox();
            this.chkInterest4 = new System.Windows.Forms.CheckBox();
            this.chkInterest5 = new System.Windows.Forms.CheckBox();
            this.chkInterest6 = new System.Windows.Forms.CheckBox();
            this.chkInterest7 = new System.Windows.Forms.CheckBox();
            this.chkChannel1 = new System.Windows.Forms.CheckBox();
            this.chkChannel2 = new System.Windows.Forms.CheckBox();
            this.chkChannel3 = new System.Windows.Forms.CheckBox();
            this.chkChannel4 = new System.Windows.Forms.CheckBox();
            this.chkChannel5 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(277, 617);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(630, 93);
            this.btnStart.TabIndex = 50;
            this.btnStart.Text = "Bắt đầu chơi";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(196, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(360, 35);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(95, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(95, 35);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Họ tên:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(596, 42);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(95, 35);
            this.lblPhoneNumber.TabIndex = 5;
            this.lblPhoneNumber.Text = "SĐT:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(697, 42);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(360, 35);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(95, 83);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(95, 35);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(196, 86);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(360, 35);
            this.txtEmail.TabIndex = 3;
            // 
            // lblCompany
            // 
            this.lblCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompany.BackColor = System.Drawing.Color.Transparent;
            this.lblCompany.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(596, 86);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(95, 35);
            this.lblCompany.TabIndex = 9;
            this.lblCompany.Text = "Công ty:";
            // 
            // txtCompany
            // 
            this.txtCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompany.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompany.Location = new System.Drawing.Point(697, 86);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(360, 35);
            this.txtCompany.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 95);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bạn đang muốn tìm hiểu và quan tâm giải pháp gì?/What solutions do you want to le" +
    "arn and are interested in?";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(601, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(510, 125);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bạn biết tới sự kiện RTC Technology Việt Nam tham gia VIMF 2025 qua kênh nào?/Thr" +
    "ough which channel did you know about RTC Technology Vietnam\'s participation in " +
    "VIMF2025?";
            // 
            // chkInterest1
            // 
            this.chkInterest1.AutoSize = true;
            this.chkInterest1.BackColor = System.Drawing.Color.Transparent;
            this.chkInterest1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInterest1.Location = new System.Drawing.Point(100, 237);
            this.chkInterest1.Name = "chkInterest1";
            this.chkInterest1.Size = new System.Drawing.Size(325, 54);
            this.chkInterest1.TabIndex = 12;
            this.chkInterest1.Text = "Giải pháp quản lý kho thông minh/\r\nSmart Warehouse Solutions";
            this.chkInterest1.UseVisualStyleBackColor = false;
            // 
            // chkInterest2
            // 
            this.chkInterest2.AutoSize = true;
            this.chkInterest2.BackColor = System.Drawing.Color.Transparent;
            this.chkInterest2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInterest2.Location = new System.Drawing.Point(100, 297);
            this.chkInterest2.Name = "chkInterest2";
            this.chkInterest2.Size = new System.Drawing.Size(481, 54);
            this.chkInterest2.TabIndex = 13;
            this.chkInterest2.Text = "Giải pháp xử lý ảnh công nghiệp Machine Vision/\r\nMachine Vision Industrial Image " +
    "Processing Solutions";
            this.chkInterest2.UseVisualStyleBackColor = false;
            // 
            // chkInterest3
            // 
            this.chkInterest3.AutoSize = true;
            this.chkInterest3.BackColor = System.Drawing.Color.Transparent;
            this.chkInterest3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInterest3.Location = new System.Drawing.Point(100, 357);
            this.chkInterest3.Name = "chkInterest3";
            this.chkInterest3.Size = new System.Drawing.Size(380, 29);
            this.chkInterest3.TabIndex = 14;
            this.chkInterest3.Text = "Giải pháp AGV/AMR/ AGV/AMR Solutions";
            this.chkInterest3.UseVisualStyleBackColor = false;
            // 
            // chkInterest4
            // 
            this.chkInterest4.AutoSize = true;
            this.chkInterest4.BackColor = System.Drawing.Color.Transparent;
            this.chkInterest4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInterest4.Location = new System.Drawing.Point(100, 392);
            this.chkInterest4.Name = "chkInterest4";
            this.chkInterest4.Size = new System.Drawing.Size(408, 54);
            this.chkInterest4.TabIndex = 15;
            this.chkInterest4.Text = "Giải pháp chế tạo máy tự động/ \r\nAutomatic Machine Manufacturing Solutions";
            this.chkInterest4.UseVisualStyleBackColor = false;
            // 
            // chkInterest5
            // 
            this.chkInterest5.AutoSize = true;
            this.chkInterest5.BackColor = System.Drawing.Color.Transparent;
            this.chkInterest5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInterest5.Location = new System.Drawing.Point(100, 452);
            this.chkInterest5.Name = "chkInterest5";
            this.chkInterest5.Size = new System.Drawing.Size(345, 54);
            this.chkInterest5.TabIndex = 16;
            this.chkInterest5.Text = "Thiết bị tự động hoá trong sản xuất/\r\nAutomation Equipment in Production";
            this.chkInterest5.UseVisualStyleBackColor = false;
            // 
            // chkInterest6
            // 
            this.chkInterest6.AutoSize = true;
            this.chkInterest6.BackColor = System.Drawing.Color.Transparent;
            this.chkInterest6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInterest6.Location = new System.Drawing.Point(100, 512);
            this.chkInterest6.Name = "chkInterest6";
            this.chkInterest6.Size = new System.Drawing.Size(354, 29);
            this.chkInterest6.TabIndex = 17;
            this.chkInterest6.Text = "IoT, OEE, SCADA, E-Factory, E-Logistics";
            this.chkInterest6.UseVisualStyleBackColor = false;
            // 
            // chkInterest7
            // 
            this.chkInterest7.AutoSize = true;
            this.chkInterest7.BackColor = System.Drawing.Color.Transparent;
            this.chkInterest7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInterest7.Location = new System.Drawing.Point(100, 547);
            this.chkInterest7.Name = "chkInterest7";
            this.chkInterest7.Size = new System.Drawing.Size(127, 29);
            this.chkInterest7.TabIndex = 18;
            this.chkInterest7.Text = "Khác/Other";
            this.chkInterest7.UseVisualStyleBackColor = false;
            // 
            // chkChannel1
            // 
            this.chkChannel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkChannel1.AutoSize = true;
            this.chkChannel1.BackColor = System.Drawing.Color.Transparent;
            this.chkChannel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChannel1.Location = new System.Drawing.Point(606, 267);
            this.chkChannel1.Name = "chkChannel1";
            this.chkChannel1.Size = new System.Drawing.Size(315, 54);
            this.chkChannel1.TabIndex = 19;
            this.chkChannel1.Text = "Tôi nhận được thư mời qua email/\r\nI received an invitation via email?";
            this.chkChannel1.UseVisualStyleBackColor = false;
            // 
            // chkChannel2
            // 
            this.chkChannel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkChannel2.AutoSize = true;
            this.chkChannel2.BackColor = System.Drawing.Color.Transparent;
            this.chkChannel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChannel2.Location = new System.Drawing.Point(606, 327);
            this.chkChannel2.Name = "chkChannel2";
            this.chkChannel2.Size = new System.Drawing.Size(262, 29);
            this.chkChannel2.TabIndex = 20;
            this.chkChannel2.Text = "Qua kênh website / website";
            this.chkChannel2.UseVisualStyleBackColor = false;
            // 
            // chkChannel3
            // 
            this.chkChannel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkChannel3.AutoSize = true;
            this.chkChannel3.BackColor = System.Drawing.Color.Transparent;
            this.chkChannel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChannel3.Location = new System.Drawing.Point(606, 362);
            this.chkChannel3.Name = "chkChannel3";
            this.chkChannel3.Size = new System.Drawing.Size(110, 29);
            this.chkChannel3.TabIndex = 21;
            this.chkChannel3.Text = "Facebook";
            this.chkChannel3.UseVisualStyleBackColor = false;
            // 
            // chkChannel4
            // 
            this.chkChannel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkChannel4.AutoSize = true;
            this.chkChannel4.BackColor = System.Drawing.Color.Transparent;
            this.chkChannel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChannel4.Location = new System.Drawing.Point(606, 397);
            this.chkChannel4.Name = "chkChannel4";
            this.chkChannel4.Size = new System.Drawing.Size(331, 54);
            this.chkChannel4.TabIndex = 22;
            this.chkChannel4.Text = "Đối tác, Bạn bè giới thiệu/\r\nPartners and Friends introduced me";
            this.chkChannel4.UseVisualStyleBackColor = false;
            // 
            // chkChannel5
            // 
            this.chkChannel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkChannel5.AutoSize = true;
            this.chkChannel5.BackColor = System.Drawing.Color.Transparent;
            this.chkChannel5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChannel5.Location = new System.Drawing.Point(606, 457);
            this.chkChannel5.Name = "chkChannel5";
            this.chkChannel5.Size = new System.Drawing.Size(127, 29);
            this.chkChannel5.TabIndex = 23;
            this.chkChannel5.Text = "Khác/Other";
            this.chkChannel5.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1169, 722);
            this.Controls.Add(this.chkChannel5);
            this.Controls.Add(this.chkChannel4);
            this.Controls.Add(this.chkChannel3);
            this.Controls.Add(this.chkChannel2);
            this.Controls.Add(this.chkChannel1);
            this.Controls.Add(this.chkInterest7);
            this.Controls.Add(this.chkInterest6);
            this.Controls.Add(this.chkInterest5);
            this.Controls.Add(this.chkInterest4);
            this.Controls.Add(this.chkInterest3);
            this.Controls.Add(this.chkInterest2);
            this.Controls.Add(this.chkInterest1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkInterest1;
        private System.Windows.Forms.CheckBox chkInterest2;
        private System.Windows.Forms.CheckBox chkInterest3;
        private System.Windows.Forms.CheckBox chkInterest4;
        private System.Windows.Forms.CheckBox chkInterest5;
        private System.Windows.Forms.CheckBox chkInterest6;
        private System.Windows.Forms.CheckBox chkInterest7;
        private System.Windows.Forms.CheckBox chkChannel1;
        private System.Windows.Forms.CheckBox chkChannel2;
        private System.Windows.Forms.CheckBox chkChannel3;
        private System.Windows.Forms.CheckBox chkChannel4;
        private System.Windows.Forms.CheckBox chkChannel5;
    }
}