namespace Raise.Monitor {
    partial class LogInformationFrm {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pageControlPanel = new System.Windows.Forms.Panel();
            this.pagerControl = new Sunlight.Dispatch.UI.Controls.PagerControl();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.A = new System.Windows.Forms.ToolStripMenuItem();
            this.B = new System.Windows.Forms.ToolStripMenuItem();
            this.C = new System.Windows.Forms.ToolStripMenuItem();
            this.D = new System.Windows.Forms.ToolStripMenuItem();
            this.E = new System.Windows.Forms.ToolStripMenuItem();
            this.gbCondition = new System.Windows.Forms.GroupBox();
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerBegin = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbDispachStatus = new System.Windows.Forms.ComboBox();
            this.txbKeyWords = new System.Windows.Forms.TextBox();
            this.txbMethod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.InterfaceConfigName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxIsWebService = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MethodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DsplayStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.gbCondition.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageControlPanel
            // 
            this.pageControlPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pageControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageControlPanel.Controls.Add(this.pagerControl);
            this.pageControlPanel.Location = new System.Drawing.Point(6, 506);
            this.pageControlPanel.Name = "pageControlPanel";
            this.pageControlPanel.Size = new System.Drawing.Size(938, 29);
            this.pageControlPanel.TabIndex = 17;
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
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.InterfaceConfigName,
            this.comboBoxIsWebService,
            this.MethodName,
            this.DsplayStatus,
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column6,
            this.Column4,
            this.Column7});
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView.Location = new System.Drawing.Point(6, 129);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(938, 370);
            this.dataGridView.TabIndex = 16;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.A,
            this.B,
            this.C,
            this.D,
            this.E});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(161, 114);
            // 
            // A
            // 
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(160, 22);
            this.A.Text = "复制报文";
            // 
            // B
            // 
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(160, 22);
            this.B.Text = "复制状态码";
            // 
            // C
            // 
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(160, 22);
            this.C.Text = "复制状态码描述";
            // 
            // D
            // 
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(160, 22);
            this.D.Text = "复制方法名称";
            // 
            // E
            // 
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(160, 22);
            this.E.Text = "复制返回消息";
            // 
            // gbCondition
            // 
            this.gbCondition.Controls.Add(this.comboBoxMethod);
            this.gbCondition.Controls.Add(this.dateTimePickerEnd);
            this.gbCondition.Controls.Add(this.label3);
            this.gbCondition.Controls.Add(this.label2);
            this.gbCondition.Controls.Add(this.dateTimePickerBegin);
            this.gbCondition.Controls.Add(this.btnSearch);
            this.gbCondition.Controls.Add(this.cmbDispachStatus);
            this.gbCondition.Controls.Add(this.txbKeyWords);
            this.gbCondition.Controls.Add(this.txbMethod);
            this.gbCondition.Controls.Add(this.label8);
            this.gbCondition.Controls.Add(this.label1);
            this.gbCondition.Controls.Add(this.label7);
            this.gbCondition.Controls.Add(this.label4);
            this.gbCondition.Location = new System.Drawing.Point(6, 33);
            this.gbCondition.Name = "gbCondition";
            this.gbCondition.Size = new System.Drawing.Size(938, 90);
            this.gbCondition.TabIndex = 15;
            this.gbCondition.TabStop = false;
            this.gbCondition.Text = "查询条件";
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Location = new System.Drawing.Point(71, 54);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(186, 20);
            this.comboBoxMethod.TabIndex = 26;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(584, 51);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.ShowCheckBox = true;
            this.dateTimePickerEnd.Size = new System.Drawing.Size(124, 21);
            this.dateTimePickerEnd.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "结束时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "开始时间";
            // 
            // dateTimePickerBegin
            // 
            this.dateTimePickerBegin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerBegin.Location = new System.Drawing.Point(584, 23);
            this.dateTimePickerBegin.Name = "dateTimePickerBegin";
            this.dateTimePickerBegin.ShowCheckBox = true;
            this.dateTimePickerBegin.Size = new System.Drawing.Size(124, 21);
            this.dateTimePickerBegin.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(743, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 52);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "查询";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // cmbDispachStatus
            // 
            this.cmbDispachStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDispachStatus.FormattingEnabled = true;
            this.cmbDispachStatus.Location = new System.Drawing.Point(333, 54);
            this.cmbDispachStatus.Name = "cmbDispachStatus";
            this.cmbDispachStatus.Size = new System.Drawing.Size(186, 20);
            this.cmbDispachStatus.TabIndex = 14;
            // 
            // txbKeyWords
            // 
            this.txbKeyWords.Location = new System.Drawing.Point(333, 23);
            this.txbKeyWords.Name = "txbKeyWords";
            this.txbKeyWords.Size = new System.Drawing.Size(187, 21);
            this.txbKeyWords.TabIndex = 12;
            // 
            // txbMethod
            // 
            this.txbMethod.Location = new System.Drawing.Point(71, 23);
            this.txbMethod.Name = "txbMethod";
            this.txbMethod.Size = new System.Drawing.Size(187, 21);
            this.txbMethod.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 59);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "调度状态";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column5.DataPropertyName = "IsSelected";
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "";
            this.Column5.MinimumWidth = 25;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 25;
            // 
            // InterfaceConfigName
            // 
            this.InterfaceConfigName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.InterfaceConfigName.DataPropertyName = "ServiceName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.InterfaceConfigName.DefaultCellStyle = dataGridViewCellStyle2;
            this.InterfaceConfigName.HeaderText = "方法名称";
            this.InterfaceConfigName.Name = "InterfaceConfigName";
            this.InterfaceConfigName.ReadOnly = true;
            this.InterfaceConfigName.Width = 78;
            // 
            // comboBoxIsWebService
            // 
            this.comboBoxIsWebService.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.comboBoxIsWebService.DataPropertyName = "IsWebService";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.comboBoxIsWebService.DefaultCellStyle = dataGridViewCellStyle3;
            this.comboBoxIsWebService.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.comboBoxIsWebService.HeaderText = "是否SOAP";
            this.comboBoxIsWebService.Name = "comboBoxIsWebService";
            this.comboBoxIsWebService.ReadOnly = true;
            this.comboBoxIsWebService.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.comboBoxIsWebService.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.comboBoxIsWebService.Width = 78;
            // 
            // MethodName
            // 
            this.MethodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MethodName.DataPropertyName = "Method";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MethodName.DefaultCellStyle = dataGridViewCellStyle4;
            this.MethodName.HeaderText = "请求类型";
            this.MethodName.MinimumWidth = 100;
            this.MethodName.Name = "MethodName";
            this.MethodName.ReadOnly = true;
            // 
            // DsplayStatus
            // 
            this.DsplayStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DsplayStatus.DataPropertyName = "OperationType";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DsplayStatus.DefaultCellStyle = dataGridViewCellStyle5;
            this.DsplayStatus.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.DsplayStatus.HeaderText = "调用状态";
            this.DsplayStatus.Name = "DsplayStatus";
            this.DsplayStatus.ReadOnly = true;
            this.DsplayStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DsplayStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DsplayStatus.Width = 78;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.DataPropertyName = "Description";
            this.Column1.HeaderText = "描述信息";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 78;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.DataPropertyName = "CreateTime";
            this.Column3.HeaderText = "创建时间";
            this.Column3.MinimumWidth = 125;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.DataPropertyName = "StatusCode";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column2.HeaderText = "状态码";
            this.Column2.MinimumWidth = 100;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column6.DataPropertyName = "StatusCodeDescription";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column6.HeaderText = "状态码描述";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 90;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column4.DataPropertyName = "Message";
            this.Column4.HeaderText = "返回消息";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 78;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "ResponseMessage";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column7.HeaderText = "报文消息";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // LogInformationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 544);
            this.Controls.Add(this.pageControlPanel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.gbCondition);
            this.Name = "LogInformationFrm";
            this.Text = "接口日志查询";
            this.pageControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.gbCondition.ResumeLayout(false);
            this.gbCondition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pageControlPanel;
        private Sunlight.Dispatch.UI.Controls.PagerControl pagerControl;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox gbCondition;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbDispachStatus;
        private System.Windows.Forms.TextBox txbKeyWords;
        private System.Windows.Forms.TextBox txbMethod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerBegin;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMethod;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem A;
        private System.Windows.Forms.ToolStripMenuItem C;
        private System.Windows.Forms.ToolStripMenuItem B;
        private System.Windows.Forms.ToolStripMenuItem D;
        private System.Windows.Forms.ToolStripMenuItem E;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterfaceConfigName;
        private System.Windows.Forms.DataGridViewComboBoxColumn comboBoxIsWebService;
        private System.Windows.Forms.DataGridViewTextBoxColumn MethodName;
        private System.Windows.Forms.DataGridViewComboBoxColumn DsplayStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}