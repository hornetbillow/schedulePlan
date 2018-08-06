namespace Raise.Monitor {
    partial class SystemLogFrm {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerBegin = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbLogLevel = new System.Windows.Forms.ComboBox();
            this.txbKeyWords = new System.Windows.Forms.TextBox();
            this.txbCallsite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.E = new System.Windows.Forms.ToolStripMenuItem();
            this.D = new System.Windows.Forms.ToolStripMenuItem();
            this.C = new System.Windows.Forms.ToolStripMenuItem();
            this.B = new System.Windows.Forms.ToolStripMenuItem();
            this.A = new System.Windows.Forms.ToolStripMenuItem();
            this.pageControlPanel = new System.Windows.Forms.Panel();
            this.pagerControl = new Sunlight.Dispatch.UI.Controls.PagerControl();
            this.gbCondition = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.errorTypeComboBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.pageControlPanel.SuspendLayout();
            this.gbCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(332, 51);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.ShowCheckBox = true;
            this.dateTimePickerEnd.Size = new System.Drawing.Size(124, 21);
            this.dateTimePickerEnd.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "结束时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "开始时间";
            // 
            // dateTimePickerBegin
            // 
            this.dateTimePickerBegin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerBegin.Location = new System.Drawing.Point(332, 23);
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
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbLogLevel
            // 
            this.cmbLogLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLogLevel.FormattingEnabled = true;
            this.cmbLogLevel.Location = new System.Drawing.Point(71, 54);
            this.cmbLogLevel.Name = "cmbLogLevel";
            this.cmbLogLevel.Size = new System.Drawing.Size(186, 20);
            this.cmbLogLevel.TabIndex = 14;
            // 
            // txbKeyWords
            // 
            this.txbKeyWords.Location = new System.Drawing.Point(530, 23);
            this.txbKeyWords.Name = "txbKeyWords";
            this.txbKeyWords.Size = new System.Drawing.Size(187, 21);
            this.txbKeyWords.TabIndex = 12;
            // 
            // txbCallsite
            // 
            this.txbCallsite.Location = new System.Drawing.Point(71, 23);
            this.txbCallsite.Name = "txbCallsite";
            this.txbCallsite.Size = new System.Drawing.Size(187, 21);
            this.txbCallsite.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "报文产生类";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "日志级别";
            // 
            // E
            // 
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(160, 22);
            this.E.Text = "复制返回消息";
            // 
            // D
            // 
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(160, 22);
            this.D.Text = "复制方法名称";
            // 
            // C
            // 
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(160, 22);
            this.C.Text = "复制状态码描述";
            // 
            // B
            // 
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(160, 22);
            this.B.Text = "复制状态码";
            // 
            // A
            // 
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(160, 22);
            this.A.Text = "复制报文";
            // 
            // pageControlPanel
            // 
            this.pageControlPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pageControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageControlPanel.Controls.Add(this.pagerControl);
            this.pageControlPanel.Location = new System.Drawing.Point(12, 481);
            this.pageControlPanel.Name = "pageControlPanel";
            this.pageControlPanel.Size = new System.Drawing.Size(938, 29);
            this.pageControlPanel.TabIndex = 20;
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
            // gbCondition
            // 
            this.gbCondition.Controls.Add(this.dateTimePickerEnd);
            this.gbCondition.Controls.Add(this.label3);
            this.gbCondition.Controls.Add(this.label2);
            this.gbCondition.Controls.Add(this.dateTimePickerBegin);
            this.gbCondition.Controls.Add(this.btnSearch);
            this.gbCondition.Controls.Add(this.cmbLogLevel);
            this.gbCondition.Controls.Add(this.txbKeyWords);
            this.gbCondition.Controls.Add(this.txbCallsite);
            this.gbCondition.Controls.Add(this.label1);
            this.gbCondition.Controls.Add(this.label7);
            this.gbCondition.Controls.Add(this.label4);
            this.gbCondition.Location = new System.Drawing.Point(12, 8);
            this.gbCondition.Name = "gbCondition";
            this.gbCondition.Size = new System.Drawing.Size(938, 90);
            this.gbCondition.TabIndex = 18;
            this.gbCondition.TabStop = false;
            this.gbCondition.Text = "查询条件";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "关键字搜索";
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
            this.errorTypeComboBoxColumn,
            this.createTimeColumn,
            this.Column7,
            this.Column1,
            this.Column2});
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.Location = new System.Drawing.Point(12, 104);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(938, 370);
            this.dataGridView.TabIndex = 19;
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
            // errorTypeComboBoxColumn
            // 
            this.errorTypeComboBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.errorTypeComboBoxColumn.DataPropertyName = "LogLevel";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.errorTypeComboBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.errorTypeComboBoxColumn.HeaderText = "日志级别";
            this.errorTypeComboBoxColumn.MinimumWidth = 100;
            this.errorTypeComboBoxColumn.Name = "errorTypeComboBoxColumn";
            this.errorTypeComboBoxColumn.ReadOnly = true;
            this.errorTypeComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // createTimeColumn
            // 
            this.createTimeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.createTimeColumn.DataPropertyName = "CreateTime";
            this.createTimeColumn.HeaderText = "创建时间";
            this.createTimeColumn.MinimumWidth = 125;
            this.createTimeColumn.Name = "createTimeColumn";
            this.createTimeColumn.ReadOnly = true;
            this.createTimeColumn.Width = 125;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "Message";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column7.HeaderText = "报文消息";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Callsite";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column1.HeaderText = "报文产生位置";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "StackTrace";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column2.HeaderText = "堆栈信息";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
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
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslInfo});
            this.statusStrip.Location = new System.Drawing.Point(0, 493);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(958, 22);
            this.statusStrip.TabIndex = 21;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = global::Raise.Monitor.Properties.Resources.image6;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(75, 17);
            this.toolStripStatusLabel1.Text = "堆栈信息:";
            // 
            // tsslInfo
            // 
            this.tsslInfo.Name = "tsslInfo";
            this.tsslInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // SystemLogFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 515);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pageControlPanel);
            this.Controls.Add(this.gbCondition);
            this.Controls.Add(this.dataGridView);
            this.Name = "SystemLogFrm";
            this.Text = "特殊日志查看";
            this.pageControlPanel.ResumeLayout(false);
            this.gbCondition.ResumeLayout(false);
            this.gbCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerBegin;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbLogLevel;
        private System.Windows.Forms.TextBox txbKeyWords;
        private System.Windows.Forms.TextBox txbCallsite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem E;
        private System.Windows.Forms.ToolStripMenuItem D;
        private System.Windows.Forms.ToolStripMenuItem C;
        private System.Windows.Forms.ToolStripMenuItem B;
        private System.Windows.Forms.ToolStripMenuItem A;
        private System.Windows.Forms.Panel pageControlPanel;
        private Sunlight.Dispatch.UI.Controls.PagerControl pagerControl;
        private System.Windows.Forms.GroupBox gbCondition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorTypeComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslInfo;
    }
}