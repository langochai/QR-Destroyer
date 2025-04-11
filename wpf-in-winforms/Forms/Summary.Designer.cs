namespace wpf_in_winforms.Forms
{
    partial class Summary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Summary));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSetting = new System.Windows.Forms.Label();
            this.cboStage = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvRank)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvRank.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvRank.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvRank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvRank.GridColor = System.Drawing.SystemColors.Window;
            this.grvRank.Location = new System.Drawing.Point(0, 100);
            this.grvRank.Name = "grvRank";
            this.grvRank.ReadOnly = true;
            this.grvRank.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvRank.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grvRank.RowHeadersVisible = false;
            this.grvRank.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.grvRank.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grvRank.RowTemplate.Height = 60;
            this.grvRank.Size = new System.Drawing.Size(752, 800);
            this.grvRank.TabIndex = 2;
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
            this.colRank.FillWeight = 20F;
            this.colRank.HeaderText = "Rank";
            this.colRank.Name = "colRank";
            this.colRank.ReadOnly = true;
            this.colRank.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "FullName";
            this.colName.FillWeight = 60F;
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPlaytime
            // 
            this.colPlaytime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPlaytime.DataPropertyName = "PlayTime";
            this.colPlaytime.FillWeight = 20F;
            this.colPlaytime.HeaderText = "Playtime";
            this.colPlaytime.Name = "colPlaytime";
            this.colPlaytime.ReadOnly = true;
            this.colPlaytime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboStage);
            this.panel1.Controls.Add(this.lblSetting);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 100);
            this.panel1.TabIndex = 3;
            // 
            // lblSetting
            // 
            this.lblSetting.AutoSize = true;
            this.lblSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetting.Location = new System.Drawing.Point(12, 28);
            this.lblSetting.Name = "lblSetting";
            this.lblSetting.Size = new System.Drawing.Size(109, 37);
            this.lblSetting.TabIndex = 0;
            this.lblSetting.Text = "Stage:";
            // 
            // cboStage
            // 
            this.cboStage.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStage.FormattingEnabled = true;
            this.cboStage.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "5",
            "6"});
            this.cboStage.Location = new System.Drawing.Point(127, 27);
            this.cboStage.Name = "cboStage";
            this.cboStage.Size = new System.Drawing.Size(121, 41);
            this.cboStage.TabIndex = 1;
            this.cboStage.SelectedIndexChanged += new System.EventHandler(this.cboStage_SelectedIndexChanged);
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 900);
            this.Controls.Add(this.grvRank);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Summary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Summary";
            this.Shown += new System.EventHandler(this.Summary_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grvRank)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grvRank;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSetting;
        private System.Windows.Forms.ComboBox cboStage;
    }
}