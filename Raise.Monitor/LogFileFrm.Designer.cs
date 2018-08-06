namespace Raise.Monitor {
    partial class LogFileFrm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pageControlPanel = new System.Windows.Forms.Panel();
            this.pagerControl = new Sunlight.Dispatch.UI.Controls.PagerControl();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.InterfaceConfigName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MethodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxDataBase = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbIsClearDateCondition = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpTimeDownloadEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeDownloadBegin = new System.Windows.Forms.DateTimePicker();
            this.Memo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrlAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DispatchTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiveMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpDateDownloadEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDownloadBegin = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txbInfoName = new System.Windows.Forms.TextBox();
            this.ExecuteStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbInfoCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbBusinessName = new System.Windows.Forms.TextBox();
            this.txbBusinessCode = new System.Windows.Forms.TextBox();
            this.BusinessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.BusinessCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.gbCondition = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpDateBegin = new System.Windows.Forms.DateTimePicker();
            this.cmbSendStatus = new System.Windows.Forms.ComboBox();
            this.txbSysCode = new System.Windows.Forms.TextBox();
            this.txbKeyWords = new System.Windows.Forms.TextBox();
            this.txbMethod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvLogInfo = new System.Windows.Forms.DataGridView();
            this.ErrMsg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageControlPanel.SuspendLayout();
            this.gbCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pageControlPanel
            // 
            this.pageControlPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pageControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageControlPanel.Controls.Add(this.pagerControl);
            this.pageControlPanel.Location = new System.Drawing.Point(12, 515);
            this.pageControlPanel.Name = "pageControlPanel";
            this.pageControlPanel.Size = new System.Drawing.Size(1087, 29);
            this.pageControlPanel.TabIndex = 20;
            // 
            // pagerControl
            // 
            this.pagerControl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pagerControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(78)))), ((int)(((byte)(151)))));
            this.pagerControl.JumpText = "Go";
            this.pagerControl.Location = new System.Drawing.Point(607, -4);
            this.pagerControl.Name = "pagerControl";
            this.pagerControl.PageIndex = 1;
            this.pagerControl.PageSize = 50;
            this.pagerControl.RecordCount = 0;
            this.pagerControl.Size = new System.Drawing.Size(474, 29);
            this.pagerControl.TabIndex = 10;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "选择";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 20;
            // 
            // InterfaceConfigName
            // 
            this.InterfaceConfigName.DataPropertyName = "Name";
            this.InterfaceConfigName.HeaderText = "接口配置名称";
            this.InterfaceConfigName.Name = "InterfaceConfigName";
            this.InterfaceConfigName.ReadOnly = true;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "接口配置编号";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // MethodName
            // 
            this.MethodName.DataPropertyName = "UpFunction";
            this.MethodName.HeaderText = "接口名称";
            this.MethodName.Name = "MethodName";
            this.MethodName.ReadOnly = true;
            // 
            // comboBoxDataBase
            // 
            this.comboBoxDataBase.FormattingEnabled = true;
            this.comboBoxDataBase.Location = new System.Drawing.Point(945, 73);
            this.comboBoxDataBase.Name = "comboBoxDataBase";
            this.comboBoxDataBase.Size = new System.Drawing.Size(142, 20);
            this.comboBoxDataBase.TabIndex = 40;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(886, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 39;
            this.label17.Text = "数据库";
            // 
            // cbIsClearDateCondition
            // 
            this.cbIsClearDateCondition.AutoSize = true;
            this.cbIsClearDateCondition.Location = new System.Drawing.Point(888, 104);
            this.cbIsClearDateCondition.Name = "cbIsClearDateCondition";
            this.cbIsClearDateCondition.Size = new System.Drawing.Size(126, 16);
            this.cbIsClearDateCondition.TabIndex = 38;
            this.cbIsClearDateCondition.Text = " 是否去掉日期条件";
            this.cbIsClearDateCondition.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(749, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 12);
            this.label13.TabIndex = 37;
            this.label13.Text = "==>";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(748, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 12);
            this.label14.TabIndex = 36;
            this.label14.Text = "==>";
            // 
            // dtpTimeDownloadEnd
            // 
            this.dtpTimeDownloadEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeDownloadEnd.Location = new System.Drawing.Point(776, 103);
            this.dtpTimeDownloadEnd.Name = "dtpTimeDownloadEnd";
            this.dtpTimeDownloadEnd.Size = new System.Drawing.Size(104, 21);
            this.dtpTimeDownloadEnd.TabIndex = 35;
            // 
            // dtpTimeDownloadBegin
            // 
            this.dtpTimeDownloadBegin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeDownloadBegin.Location = new System.Drawing.Point(640, 103);
            this.dtpTimeDownloadBegin.Name = "dtpTimeDownloadBegin";
            this.dtpTimeDownloadBegin.Size = new System.Drawing.Size(104, 21);
            this.dtpTimeDownloadBegin.TabIndex = 34;
            // 
            // Memo
            // 
            this.Memo.DataPropertyName = "Memo";
            this.Memo.HeaderText = "备注";
            this.Memo.Name = "Memo";
            this.Memo.ReadOnly = true;
            // 
            // UrlAddress
            // 
            this.UrlAddress.DataPropertyName = "Url";
            this.UrlAddress.HeaderText = "文件路径";
            this.UrlAddress.Name = "UrlAddress";
            this.UrlAddress.ReadOnly = true;
            // 
            // DispatchTime
            // 
            this.DispatchTime.DataPropertyName = "UpTime";
            this.DispatchTime.HeaderText = "上传时间";
            this.DispatchTime.Name = "DispatchTime";
            this.DispatchTime.ReadOnly = true;
            // 
            // ReceiveMethod
            // 
            this.ReceiveMethod.DataPropertyName = "DownFunction";
            this.ReceiveMethod.HeaderText = "接收方法";
            this.ReceiveMethod.Name = "ReceiveMethod";
            this.ReceiveMethod.ReadOnly = true;
            // 
            // dtpDateDownloadEnd
            // 
            this.dtpDateDownloadEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDownloadEnd.Location = new System.Drawing.Point(775, 72);
            this.dtpDateDownloadEnd.Name = "dtpDateDownloadEnd";
            this.dtpDateDownloadEnd.Size = new System.Drawing.Size(104, 21);
            this.dtpDateDownloadEnd.TabIndex = 33;
            // 
            // dtpDateDownloadBegin
            // 
            this.dtpDateDownloadBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDownloadBegin.Location = new System.Drawing.Point(639, 72);
            this.dtpDateDownloadBegin.Name = "dtpDateDownloadBegin";
            this.dtpDateDownloadBegin.Size = new System.Drawing.Size(104, 21);
            this.dtpDateDownloadBegin.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(559, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 12);
            this.label15.TabIndex = 31;
            this.label15.Text = "下发时间区间";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(559, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 12);
            this.label16.TabIndex = 30;
            this.label16.Text = "下发时间范围";
            // 
            // txbInfoName
            // 
            this.txbInfoName.Location = new System.Drawing.Point(361, 104);
            this.txbInfoName.Name = "txbInfoName";
            this.txbInfoName.Size = new System.Drawing.Size(187, 21);
            this.txbInfoName.TabIndex = 29;
            // 
            // ExecuteStatus
            // 
            this.ExecuteStatus.DataPropertyName = "SendStatus";
            this.ExecuteStatus.HeaderText = "下发状态";
            this.ExecuteStatus.Name = "ExecuteStatus";
            this.ExecuteStatus.ReadOnly = true;
            // 
            // txbInfoCode
            // 
            this.txbInfoCode.Location = new System.Drawing.Point(361, 78);
            this.txbInfoCode.Name = "txbInfoCode";
            this.txbInfoCode.Size = new System.Drawing.Size(187, 21);
            this.txbInfoCode.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(278, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 26;
            this.label11.Text = "接口配置编号";
            // 
            // txbBusinessName
            // 
            this.txbBusinessName.Location = new System.Drawing.Point(79, 106);
            this.txbBusinessName.Name = "txbBusinessName";
            this.txbBusinessName.Size = new System.Drawing.Size(187, 21);
            this.txbBusinessName.TabIndex = 25;
            // 
            // txbBusinessCode
            // 
            this.txbBusinessCode.Location = new System.Drawing.Point(80, 77);
            this.txbBusinessCode.Name = "txbBusinessCode";
            this.txbBusinessCode.Size = new System.Drawing.Size(187, 21);
            this.txbBusinessCode.TabIndex = 24;
            // 
            // BusinessName
            // 
            this.BusinessName.DataPropertyName = "BusinessCode";
            this.BusinessName.HeaderText = "业务分类编号";
            this.BusinessName.Name = "BusinessName";
            this.BusinessName.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Downer";
            this.Column2.HeaderText = "接收方";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Uper";
            this.Column1.HeaderText = "发送方";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaxNum";
            this.Column4.HeaderText = "最大同步条数";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(278, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 27;
            this.label12.Text = "接口配置名称";
            // 
            // BusinessCode
            // 
            this.BusinessCode.HeaderText = "业务分类编号";
            this.BusinessCode.Name = "BusinessCode";
            this.BusinessCode.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "业务分类名称";
            // 
            // gbCondition
            // 
            this.gbCondition.Controls.Add(this.comboBoxDataBase);
            this.gbCondition.Controls.Add(this.label17);
            this.gbCondition.Controls.Add(this.cbIsClearDateCondition);
            this.gbCondition.Controls.Add(this.label13);
            this.gbCondition.Controls.Add(this.label14);
            this.gbCondition.Controls.Add(this.dtpTimeDownloadEnd);
            this.gbCondition.Controls.Add(this.dtpTimeDownloadBegin);
            this.gbCondition.Controls.Add(this.dtpDateDownloadEnd);
            this.gbCondition.Controls.Add(this.dtpDateDownloadBegin);
            this.gbCondition.Controls.Add(this.label15);
            this.gbCondition.Controls.Add(this.label16);
            this.gbCondition.Controls.Add(this.txbInfoName);
            this.gbCondition.Controls.Add(this.txbInfoCode);
            this.gbCondition.Controls.Add(this.label12);
            this.gbCondition.Controls.Add(this.label11);
            this.gbCondition.Controls.Add(this.txbBusinessName);
            this.gbCondition.Controls.Add(this.txbBusinessCode);
            this.gbCondition.Controls.Add(this.label10);
            this.gbCondition.Controls.Add(this.label9);
            this.gbCondition.Controls.Add(this.btnSearch);
            this.gbCondition.Controls.Add(this.label3);
            this.gbCondition.Controls.Add(this.label2);
            this.gbCondition.Controls.Add(this.dtpTimeEnd);
            this.gbCondition.Controls.Add(this.dtpTimeBegin);
            this.gbCondition.Controls.Add(this.dtpDateEnd);
            this.gbCondition.Controls.Add(this.dtpDateBegin);
            this.gbCondition.Controls.Add(this.cmbSendStatus);
            this.gbCondition.Controls.Add(this.txbSysCode);
            this.gbCondition.Controls.Add(this.txbKeyWords);
            this.gbCondition.Controls.Add(this.txbMethod);
            this.gbCondition.Controls.Add(this.label8);
            this.gbCondition.Controls.Add(this.label1);
            this.gbCondition.Controls.Add(this.label7);
            this.gbCondition.Controls.Add(this.label4);
            this.gbCondition.Controls.Add(this.label6);
            this.gbCondition.Controls.Add(this.label5);
            this.gbCondition.Location = new System.Drawing.Point(12, 7);
            this.gbCondition.Name = "gbCondition";
            this.gbCondition.Size = new System.Drawing.Size(1268, 129);
            this.gbCondition.TabIndex = 18;
            this.gbCondition.TabStop = false;
            this.gbCondition.Text = "查询条件";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "业务分类编号";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(904, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 52);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "查询";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(749, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "==>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(748, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "==>";
            // 
            // dtpTimeEnd
            // 
            this.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeEnd.Location = new System.Drawing.Point(776, 43);
            this.dtpTimeEnd.Name = "dtpTimeEnd";
            this.dtpTimeEnd.Size = new System.Drawing.Size(104, 21);
            this.dtpTimeEnd.TabIndex = 18;
            // 
            // dtpTimeBegin
            // 
            this.dtpTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeBegin.Location = new System.Drawing.Point(640, 43);
            this.dtpTimeBegin.Name = "dtpTimeBegin";
            this.dtpTimeBegin.Size = new System.Drawing.Size(104, 21);
            this.dtpTimeBegin.TabIndex = 17;
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateEnd.Location = new System.Drawing.Point(775, 12);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(104, 21);
            this.dtpDateEnd.TabIndex = 16;
            // 
            // dtpDateBegin
            // 
            this.dtpDateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateBegin.Location = new System.Drawing.Point(639, 12);
            this.dtpDateBegin.Name = "dtpDateBegin";
            this.dtpDateBegin.Size = new System.Drawing.Size(104, 21);
            this.dtpDateBegin.TabIndex = 15;
            // 
            // cmbSendStatus
            // 
            this.cmbSendStatus.FormattingEnabled = true;
            this.cmbSendStatus.Location = new System.Drawing.Point(361, 43);
            this.cmbSendStatus.Name = "cmbSendStatus";
            this.cmbSendStatus.Size = new System.Drawing.Size(186, 20);
            this.cmbSendStatus.TabIndex = 14;
            // 
            // txbSysCode
            // 
            this.txbSysCode.Location = new System.Drawing.Point(80, 43);
            this.txbSysCode.Name = "txbSysCode";
            this.txbSysCode.Size = new System.Drawing.Size(187, 21);
            this.txbSysCode.TabIndex = 13;
            // 
            // txbKeyWords
            // 
            this.txbKeyWords.Location = new System.Drawing.Point(361, 12);
            this.txbKeyWords.Name = "txbKeyWords";
            this.txbKeyWords.Size = new System.Drawing.Size(187, 21);
            this.txbKeyWords.TabIndex = 12;
            // 
            // txbMethod
            // 
            this.txbMethod.Location = new System.Drawing.Point(80, 12);
            this.txbMethod.Name = "txbMethod";
            this.txbMethod.Size = new System.Drawing.Size(187, 21);
            this.txbMethod.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "系统编号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "接口名称";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "关键字搜索";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "下发状态";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(559, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "上传时间区间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(559, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "上传时间范围";
            // 
            // dgvLogInfo
            // 
            this.dgvLogInfo.AllowUserToAddRows = false;
            this.dgvLogInfo.AllowUserToDeleteRows = false;
            this.dgvLogInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.InterfaceConfigName,
            this.Code,
            this.MethodName,
            this.BusinessName,
            this.BusinessCode,
            this.Column4,
            this.Column1,
            this.Column2,
            this.ExecuteStatus,
            this.ReceiveMethod,
            this.DispatchTime,
            this.UrlAddress,
            this.ErrMsg,
            this.Memo});
            this.dgvLogInfo.Location = new System.Drawing.Point(12, 142);
            this.dgvLogInfo.Name = "dgvLogInfo";
            this.dgvLogInfo.ReadOnly = true;
            this.dgvLogInfo.RowTemplate.Height = 23;
            this.dgvLogInfo.Size = new System.Drawing.Size(1087, 370);
            this.dgvLogInfo.TabIndex = 19;
            // 
            // ErrMsg
            // 
            this.ErrMsg.DataPropertyName = "FileName";
            this.ErrMsg.HeaderText = "文件名称";
            this.ErrMsg.Name = "ErrMsg";
            this.ErrMsg.ReadOnly = true;
            // 
            // LogFileFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 775);
            this.Controls.Add(this.pageControlPanel);
            this.Controls.Add(this.gbCondition);
            this.Controls.Add(this.dgvLogInfo);
            this.Name = "LogFileFrm";
            this.Text = "日志文件查看";
            this.pageControlPanel.ResumeLayout(false);
            this.gbCondition.ResumeLayout(false);
            this.gbCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pageControlPanel;
        private Sunlight.Dispatch.UI.Controls.PagerControl pagerControl;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterfaceConfigName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn MethodName;
        private System.Windows.Forms.ComboBox comboBoxDataBase;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox cbIsClearDateCondition;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpTimeDownloadEnd;
        private System.Windows.Forms.DateTimePicker dtpTimeDownloadBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrlAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn DispatchTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiveMethod;
        private System.Windows.Forms.DateTimePicker dtpDateDownloadEnd;
        private System.Windows.Forms.DateTimePicker dtpDateDownloadBegin;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txbInfoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExecuteStatus;
        private System.Windows.Forms.TextBox txbInfoCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbBusinessName;
        private System.Windows.Forms.TextBox txbBusinessCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusinessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusinessCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbCondition;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTimeEnd;
        private System.Windows.Forms.DateTimePicker dtpTimeBegin;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.DateTimePicker dtpDateBegin;
        private System.Windows.Forms.ComboBox cmbSendStatus;
        private System.Windows.Forms.TextBox txbSysCode;
        private System.Windows.Forms.TextBox txbKeyWords;
        private System.Windows.Forms.TextBox txbMethod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvLogInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrMsg;
    }
}