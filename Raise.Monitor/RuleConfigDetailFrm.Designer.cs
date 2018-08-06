namespace Raise.Monitor {
    partial class RuleConfigDetailFrm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RuleConfigDetailFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbWebService = new System.Windows.Forms.RadioButton();
            this.rbRestful = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txbGroupName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbIsOData = new System.Windows.Forms.CheckBox();
            this.txbParameters = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.txbCron = new System.Windows.Forms.TextBox();
            this.txbJob = new System.Windows.Forms.TextBox();
            this.txbTrigger = new System.Windows.Forms.TextBox();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbMethod = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbContentType = new System.Windows.Forms.TextBox();
            this.txbRunStatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.rbWebService);
            this.panel1.Controls.Add(this.rbRestful);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(161, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 32);
            this.panel1.TabIndex = 65;
            // 
            // rbWebService
            // 
            this.rbWebService.AutoSize = true;
            this.rbWebService.Location = new System.Drawing.Point(3, 8);
            this.rbWebService.Name = "rbWebService";
            this.rbWebService.Size = new System.Drawing.Size(83, 16);
            this.rbWebService.TabIndex = 0;
            this.rbWebService.TabStop = true;
            this.rbWebService.Text = "WebService";
            this.rbWebService.UseVisualStyleBackColor = true;
            // 
            // rbRestful
            // 
            this.rbRestful.AutoSize = true;
            this.rbRestful.Location = new System.Drawing.Point(119, 9);
            this.rbRestful.Name = "rbRestful";
            this.rbRestful.Size = new System.Drawing.Size(65, 16);
            this.rbRestful.TabIndex = 1;
            this.rbRestful.TabStop = true;
            this.rbRestful.Text = "Restful";
            this.rbRestful.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(67, 413);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 64;
            this.label8.Text = "Is WebService";
            // 
            // txbGroupName
            // 
            this.txbGroupName.Location = new System.Drawing.Point(161, 162);
            this.txbGroupName.Name = "txbGroupName";
            this.txbGroupName.ReadOnly = true;
            this.txbGroupName.Size = new System.Drawing.Size(477, 21);
            this.txbGroupName.TabIndex = 63;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(79, 166);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 62;
            this.label13.Text = "Group Name";
            // 
            // cbIsOData
            // 
            this.cbIsOData.AutoSize = true;
            this.cbIsOData.Enabled = false;
            this.cbIsOData.Location = new System.Drawing.Point(161, 386);
            this.cbIsOData.Name = "cbIsOData";
            this.cbIsOData.Size = new System.Drawing.Size(78, 16);
            this.cbIsOData.TabIndex = 61;
            this.cbIsOData.Text = "oData凭证";
            this.cbIsOData.UseVisualStyleBackColor = true;
            // 
            // txbParameters
            // 
            this.txbParameters.Location = new System.Drawing.Point(161, 193);
            this.txbParameters.Multiline = true;
            this.txbParameters.Name = "txbParameters";
            this.txbParameters.ReadOnly = true;
            this.txbParameters.Size = new System.Drawing.Size(477, 115);
            this.txbParameters.TabIndex = 58;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(85, 196);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 57;
            this.label12.Text = "Parameters";
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(161, 102);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.ReadOnly = true;
            this.txbAddress.Size = new System.Drawing.Size(477, 21);
            this.txbAddress.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(79, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 55;
            this.label6.Text = "URL Address";
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMethod.Enabled = false;
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Items.AddRange(new object[] {
            "POST",
            "GET"});
            this.comboBoxMethod.Location = new System.Drawing.Point(161, 133);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(477, 20);
            this.comboBoxMethod.TabIndex = 54;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(161, 479);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.ReadOnly = true;
            this.txbPassword.Size = new System.Drawing.Size(477, 21);
            this.txbPassword.TabIndex = 52;
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(161, 448);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.ReadOnly = true;
            this.txbUserName.Size = new System.Drawing.Size(477, 21);
            this.txbUserName.TabIndex = 51;
            // 
            // txbCron
            // 
            this.txbCron.Location = new System.Drawing.Point(161, 351);
            this.txbCron.Name = "txbCron";
            this.txbCron.ReadOnly = true;
            this.txbCron.Size = new System.Drawing.Size(477, 21);
            this.txbCron.TabIndex = 50;
            // 
            // txbJob
            // 
            this.txbJob.Location = new System.Drawing.Point(161, 72);
            this.txbJob.Name = "txbJob";
            this.txbJob.ReadOnly = true;
            this.txbJob.Size = new System.Drawing.Size(477, 21);
            this.txbJob.TabIndex = 49;
            // 
            // txbTrigger
            // 
            this.txbTrigger.Location = new System.Drawing.Point(161, 42);
            this.txbTrigger.Name = "txbTrigger";
            this.txbTrigger.ReadOnly = true;
            this.txbTrigger.Size = new System.Drawing.Size(477, 21);
            this.txbTrigger.TabIndex = 48;
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(161, 510);
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.ReadOnly = true;
            this.txbDescription.Size = new System.Drawing.Size(477, 118);
            this.txbDescription.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 510);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 12);
            this.label11.TabIndex = 46;
            this.label11.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(73, 324);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 45;
            this.label10.Text = "Content-Type";
            // 
            // txbMethod
            // 
            this.txbMethod.Location = new System.Drawing.Point(161, 12);
            this.txbMethod.Name = "txbMethod";
            this.txbMethod.ReadOnly = true;
            this.txbMethod.Size = new System.Drawing.Size(477, 21);
            this.txbMethod.TabIndex = 44;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(97, 481);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 12);
            this.lblPassword.TabIndex = 43;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(97, 452);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(53, 12);
            this.lblUserName.TabIndex = 42;
            this.lblUserName.Text = "UserName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(7, 386);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 12);
            this.label7.TabIndex = 41;
            this.label7.Text = "Is oData Authentication";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(49, 353);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 40;
            this.label5.Text = "CRON Expression";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(109, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 39;
            this.label4.Text = "Mehtod";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(97, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 38;
            this.label3.Text = "JOB Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(73, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 37;
            this.label2.Text = "Trigger Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(79, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 36;
            this.label1.Text = "Method Name";
            // 
            // txbContentType
            // 
            this.txbContentType.Location = new System.Drawing.Point(161, 321);
            this.txbContentType.Name = "txbContentType";
            this.txbContentType.ReadOnly = true;
            this.txbContentType.Size = new System.Drawing.Size(477, 21);
            this.txbContentType.TabIndex = 66;
            // 
            // txbRunStatus
            // 
            this.txbRunStatus.Location = new System.Drawing.Point(457, 387);
            this.txbRunStatus.Name = "txbRunStatus";
            this.txbRunStatus.ReadOnly = true;
            this.txbRunStatus.Size = new System.Drawing.Size(181, 21);
            this.txbRunStatus.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(387, 391);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 67;
            this.label9.Text = "Run status";
            // 
            // txbStatus
            // 
            this.txbStatus.Location = new System.Drawing.Point(457, 418);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.ReadOnly = true;
            this.txbStatus.Size = new System.Drawing.Size(181, 21);
            this.txbStatus.TabIndex = 70;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(411, 421);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 69;
            this.label14.Text = "Status";
            // 
            // RuleConfigDetailFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 648);
            this.Controls.Add(this.txbStatus);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txbRunStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbContentType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbGroupName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbIsOData);
            this.Controls.Add(this.txbParameters);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxMethod);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.txbCron);
            this.Controls.Add(this.txbJob);
            this.Controls.Add(this.txbTrigger);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbMethod);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RuleConfigDetailFrm";
            this.Text = "查看配置明细";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbWebService;
        private System.Windows.Forms.RadioButton rbRestful;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbGroupName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cbIsOData;
        private System.Windows.Forms.TextBox txbParameters;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxMethod;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.TextBox txbCron;
        private System.Windows.Forms.TextBox txbJob;
        private System.Windows.Forms.TextBox txbTrigger;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbMethod;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbContentType;
        private System.Windows.Forms.TextBox txbRunStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Label label14;
    }
}