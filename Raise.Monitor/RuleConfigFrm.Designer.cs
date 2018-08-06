namespace Raise.Monitor {
    partial class RuleConfigFrm {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RuleConfigFrm));
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbRunStatus = new System.Windows.Forms.ComboBox();
            this.txbKeyWords = new System.Windows.Forms.TextBox();
            this.pageControlPanel = new System.Windows.Forms.Panel();
            this.pagerControl = new Sunlight.Dispatch.UI.Controls.PagerControl();
            this.txbServiceName = new System.Windows.Forms.TextBox();
            this.dataGridRule = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TriggerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cron = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RunStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsWebService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oDataGridViewComboBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descritpion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrlAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostBody = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCondition = new System.Windows.Forms.GroupBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRequestType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbInsert = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsbRecovery = new System.Windows.Forms.ToolStripButton();
            this.tsbAbandon = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.tsbDetails = new System.Windows.Forms.ToolStripButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pageControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRule)).BeginInit();
            this.gbCondition.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(847, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 52);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "查询";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbRunStatus
            // 
            this.cmbRunStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRunStatus.FormattingEnabled = true;
            this.cmbRunStatus.Location = new System.Drawing.Point(333, 54);
            this.cmbRunStatus.Name = "cmbRunStatus";
            this.cmbRunStatus.Size = new System.Drawing.Size(186, 20);
            this.cmbRunStatus.TabIndex = 14;
            // 
            // txbKeyWords
            // 
            this.txbKeyWords.Location = new System.Drawing.Point(333, 23);
            this.txbKeyWords.Name = "txbKeyWords";
            this.txbKeyWords.Size = new System.Drawing.Size(187, 21);
            this.txbKeyWords.TabIndex = 12;
            // 
            // pageControlPanel
            // 
            this.pageControlPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pageControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageControlPanel.Controls.Add(this.pagerControl);
            this.pageControlPanel.Location = new System.Drawing.Point(4, 541);
            this.pageControlPanel.Name = "pageControlPanel";
            this.pageControlPanel.Size = new System.Drawing.Size(938, 29);
            this.pageControlPanel.TabIndex = 14;
            // 
            // pagerControl
            // 
            this.pagerControl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pagerControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(78)))), ((int)(((byte)(151)))));
            this.pagerControl.JumpText = "Go";
            this.pagerControl.Location = new System.Drawing.Point(464, -1);
            this.pagerControl.Name = "pagerControl";
            this.pagerControl.PageIndex = 1;
            this.pagerControl.PageSize = 50;
            this.pagerControl.RecordCount = 0;
            this.pagerControl.Size = new System.Drawing.Size(474, 29);
            this.pagerControl.TabIndex = 10;
            // 
            // txbServiceName
            // 
            this.txbServiceName.Location = new System.Drawing.Point(71, 23);
            this.txbServiceName.Name = "txbServiceName";
            this.txbServiceName.Size = new System.Drawing.Size(187, 21);
            this.txbServiceName.TabIndex = 8;
            this.toolTip.SetToolTip(this.txbServiceName, "关键字搜索支持全模糊");
            // 
            // dataGridRule
            // 
            this.dataGridRule.AllowUserToAddRows = false;
            this.dataGridRule.AllowUserToDeleteRows = false;
            this.dataGridRule.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.ServiceName,
            this.Method,
            this.TriggerName,
            this.JobName,
            this.ContentType,
            this.GroupName,
            this.Cron,
            this.Status,
            this.RunStatusColumn,
            this.IsWebService,
            this.oDataGridViewComboBox,
            this.UserName,
            this.Password,
            this.Descritpion,
            this.UrlAddress,
            this.PostBody});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridRule.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridRule.Location = new System.Drawing.Point(4, 123);
            this.dataGridRule.Name = "dataGridRule";
            this.dataGridRule.ReadOnly = true;
            this.dataGridRule.RowTemplate.Height = 23;
            this.dataGridRule.Size = new System.Drawing.Size(938, 370);
            this.dataGridRule.TabIndex = 13;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column5.HeaderText = "";
            this.Column5.MinimumWidth = 25;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 25;
            // 
            // ServiceName
            // 
            this.ServiceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ServiceName.DataPropertyName = "ServiceName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ServiceName.DefaultCellStyle = dataGridViewCellStyle2;
            this.ServiceName.HeaderText = "接口名称";
            this.ServiceName.MinimumWidth = 25;
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            this.ServiceName.Width = 61;
            // 
            // Method
            // 
            this.Method.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Method.DataPropertyName = "Method";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Method.DefaultCellStyle = dataGridViewCellStyle3;
            this.Method.HeaderText = "请求类型";
            this.Method.MinimumWidth = 100;
            this.Method.Name = "Method";
            this.Method.ReadOnly = true;
            this.Method.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TriggerName
            // 
            this.TriggerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TriggerName.DataPropertyName = "TriggerName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.TriggerName.DefaultCellStyle = dataGridViewCellStyle4;
            this.TriggerName.HeaderText = "触发器名称";
            this.TriggerName.MinimumWidth = 100;
            this.TriggerName.Name = "TriggerName";
            this.TriggerName.ReadOnly = true;
            // 
            // JobName
            // 
            this.JobName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.JobName.DataPropertyName = "JobName";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.JobName.DefaultCellStyle = dataGridViewCellStyle5;
            this.JobName.HeaderText = "作业名称";
            this.JobName.MinimumWidth = 100;
            this.JobName.Name = "JobName";
            this.JobName.ReadOnly = true;
            // 
            // ContentType
            // 
            this.ContentType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ContentType.DataPropertyName = "ContentType";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ContentType.DefaultCellStyle = dataGridViewCellStyle6;
            this.ContentType.HeaderText = "Content-Type";
            this.ContentType.MinimumWidth = 100;
            this.ContentType.Name = "ContentType";
            this.ContentType.ReadOnly = true;
            this.ContentType.Width = 102;
            // 
            // GroupName
            // 
            this.GroupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GroupName.DataPropertyName = "GroupName";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.GroupName.DefaultCellStyle = dataGridViewCellStyle7;
            this.GroupName.HeaderText = "分组名称";
            this.GroupName.MinimumWidth = 100;
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            // 
            // Cron
            // 
            this.Cron.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cron.DataPropertyName = "Cron";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Cron.DefaultCellStyle = dataGridViewCellStyle8;
            this.Cron.HeaderText = "调度规则";
            this.Cron.MinimumWidth = 100;
            this.Cron.Name = "Cron";
            this.Cron.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Status.DataPropertyName = "Status";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Status.DefaultCellStyle = dataGridViewCellStyle9;
            this.Status.HeaderText = "状态";
            this.Status.MinimumWidth = 60;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.Width = 60;
            // 
            // RunStatusColumn
            // 
            this.RunStatusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RunStatusColumn.DataPropertyName = "RunStatus";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RunStatusColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.RunStatusColumn.HeaderText = "运行状态";
            this.RunStatusColumn.MinimumWidth = 100;
            this.RunStatusColumn.Name = "RunStatusColumn";
            this.RunStatusColumn.ReadOnly = true;
            this.RunStatusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // IsWebService
            // 
            this.IsWebService.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IsWebService.DataPropertyName = "IsWebService";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IsWebService.DefaultCellStyle = dataGridViewCellStyle11;
            this.IsWebService.HeaderText = "SOAP请求";
            this.IsWebService.MinimumWidth = 100;
            this.IsWebService.Name = "IsWebService";
            this.IsWebService.ReadOnly = true;
            this.IsWebService.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // oDataGridViewComboBox
            // 
            this.oDataGridViewComboBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.oDataGridViewComboBox.DataPropertyName = "IsAuthentication";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.oDataGridViewComboBox.DefaultCellStyle = dataGridViewCellStyle12;
            this.oDataGridViewComboBox.HeaderText = "是否需凭证";
            this.oDataGridViewComboBox.MinimumWidth = 100;
            this.oDataGridViewComboBox.Name = "oDataGridViewComboBox";
            this.oDataGridViewComboBox.ReadOnly = true;
            this.oDataGridViewComboBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "认证用户名称";
            this.UserName.MinimumWidth = 100;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "认证用户密码";
            this.Password.MinimumWidth = 100;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Descritpion
            // 
            this.Descritpion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Descritpion.DataPropertyName = "Description";
            this.Descritpion.HeaderText = "描述信息";
            this.Descritpion.MinimumWidth = 100;
            this.Descritpion.Name = "Descritpion";
            this.Descritpion.ReadOnly = true;
            // 
            // UrlAddress
            // 
            this.UrlAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UrlAddress.DataPropertyName = "Address";
            this.UrlAddress.HeaderText = "地址";
            this.UrlAddress.MinimumWidth = 200;
            this.UrlAddress.Name = "UrlAddress";
            this.UrlAddress.ReadOnly = true;
            this.UrlAddress.Width = 200;
            // 
            // PostBody
            // 
            this.PostBody.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PostBody.DataPropertyName = "PostBody";
            this.PostBody.HeaderText = "参数体";
            this.PostBody.Name = "PostBody";
            this.PostBody.ReadOnly = true;
            // 
            // gbCondition
            // 
            this.gbCondition.Controls.Add(this.comboBoxStatus);
            this.gbCondition.Controls.Add(this.label2);
            this.gbCondition.Controls.Add(this.cmbRequestType);
            this.gbCondition.Controls.Add(this.btnSearch);
            this.gbCondition.Controls.Add(this.cmbRunStatus);
            this.gbCondition.Controls.Add(this.txbKeyWords);
            this.gbCondition.Controls.Add(this.txbServiceName);
            this.gbCondition.Controls.Add(this.label8);
            this.gbCondition.Controls.Add(this.label1);
            this.gbCondition.Controls.Add(this.label7);
            this.gbCondition.Controls.Add(this.lable);
            this.gbCondition.Location = new System.Drawing.Point(4, 28);
            this.gbCondition.Name = "gbCondition";
            this.gbCondition.Size = new System.Drawing.Size(938, 90);
            this.gbCondition.TabIndex = 12;
            this.gbCondition.TabStop = false;
            this.gbCondition.Text = "查询条件";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(564, 24);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(186, 20);
            this.comboBoxStatus.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "状态";
            // 
            // cmbRequestType
            // 
            this.cmbRequestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRequestType.FormattingEnabled = true;
            this.cmbRequestType.Location = new System.Drawing.Point(73, 54);
            this.cmbRequestType.Name = "cmbRequestType";
            this.cmbRequestType.Size = new System.Drawing.Size(186, 20);
            this.cmbRequestType.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "请求类型";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "接口名称";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "关键字搜索";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(278, 59);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(53, 12);
            this.lable.TabIndex = 3;
            this.lable.Text = "运行状态";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbInsert,
            this.tsbUpdate,
            this.tsbRecovery,
            this.tsbAbandon,
            this.toolStripButtonStart,
            this.toolStripButtonStop,
            this.tsbDetails});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(967, 25);
            this.toolStrip.TabIndex = 15;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsbInsert
            // 
            this.tsbInsert.Image = global::Raise.Monitor.Properties.Resources.image1;
            this.tsbInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInsert.Name = "tsbInsert";
            this.tsbInsert.Size = new System.Drawing.Size(52, 22);
            this.tsbInsert.Text = "新增";
            this.tsbInsert.Click += new System.EventHandler(this.tsbInsert_Click);
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.Image = global::Raise.Monitor.Properties.Resources.image2;
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(52, 22);
            this.tsbUpdate.Text = "修改";
            this.tsbUpdate.Click += new System.EventHandler(this.tsbUpdate_Click);
            // 
            // tsbRecovery
            // 
            this.tsbRecovery.Image = global::Raise.Monitor.Properties.Resources.image8;
            this.tsbRecovery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRecovery.Name = "tsbRecovery";
            this.tsbRecovery.Size = new System.Drawing.Size(52, 22);
            this.tsbRecovery.Text = "恢复";
            this.tsbRecovery.Click += new System.EventHandler(this.tsbRecovery_Click);
            // 
            // tsbAbandon
            // 
            this.tsbAbandon.Image = global::Raise.Monitor.Properties.Resources.image3;
            this.tsbAbandon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAbandon.Name = "tsbAbandon";
            this.tsbAbandon.Size = new System.Drawing.Size(52, 22);
            this.tsbAbandon.Text = "作废";
            this.tsbAbandon.ToolTipText = "作废";
            this.tsbAbandon.Click += new System.EventHandler(this.tsbAbandon_Click);
            // 
            // toolStripButtonStart
            // 
            this.toolStripButtonStart.Image = global::Raise.Monitor.Properties.Resources.image4;
            this.toolStripButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStart.Name = "toolStripButtonStart";
            this.toolStripButtonStart.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonStart.Text = "启用";
            this.toolStripButtonStart.Click += new System.EventHandler(this.toolStripButtonStart_Click);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.Image = global::Raise.Monitor.Properties.Resources.image5;
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonStop.Text = "停用";
            this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStop_Click);
            // 
            // tsbDetails
            // 
            this.tsbDetails.Image = global::Raise.Monitor.Properties.Resources.image9;
            this.tsbDetails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDetails.Name = "tsbDetails";
            this.tsbDetails.Size = new System.Drawing.Size(76, 22);
            this.tsbDetails.Text = "查看明细";
            this.tsbDetails.Click += new System.EventHandler(this.tsbDetails_Click);
            // 
            // toolTip
            // 
            this.toolTip.ToolTipTitle = "大小写不敏感，且支持左模糊";
            // 
            // RuleConfigFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 580);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.pageControlPanel);
            this.Controls.Add(this.dataGridRule);
            this.Controls.Add(this.gbCondition);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RuleConfigFrm";
            this.Text = "调度规则配置";
            this.pageControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRule)).EndInit();
            this.gbCondition.ResumeLayout(false);
            this.gbCondition.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbRunStatus;
        private System.Windows.Forms.TextBox txbKeyWords;
        private System.Windows.Forms.Panel pageControlPanel;
        private Sunlight.Dispatch.UI.Controls.PagerControl pagerControl;
        private System.Windows.Forms.TextBox txbServiceName;
        private System.Windows.Forms.DataGridView dataGridRule;
        private System.Windows.Forms.GroupBox gbCondition;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.ComboBox cmbRequestType;
        private System.Windows.Forms.ToolStripButton tsbInsert;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.ToolStripButton tsbAbandon;
        private System.Windows.Forms.ToolStripButton toolStripButtonStart;
        private System.Windows.Forms.ToolStripButton toolStripButtonStop;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripButton tsbRecovery;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Method;
        private System.Windows.Forms.DataGridViewTextBoxColumn TriggerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cron;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn RunStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsWebService;
        private System.Windows.Forms.DataGridViewTextBoxColumn oDataGridViewComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descritpion;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrlAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostBody;
        private System.Windows.Forms.ToolStripButton tsbDetails;
    }
}