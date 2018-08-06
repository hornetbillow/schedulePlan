using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Raise.Monitor.Controls;
using Raise.Monitor.Model;
using Raise.Monitor.Service;
using Raise.Monitor.Tools;

namespace Raise.Monitor {
    public partial class RuleConfigInsertFrm : BaseFrm {
        public RuleConfigInsertFrm() {
            InitializeComponent();
            this.Load += RuleConfigFrm_Load;
        }

        private void RuleConfigFrm_Load(object sender, EventArgs e) {
            this.txbUserName.ReadOnly = !this.cbIsOData.Checked;
            this.txbPassword.ReadOnly = !this.cbIsOData.Checked;
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            var methodName = this.txbMethod.Text;
            var triggerName = this.txbTrigger.Text;
            var jobName = this.txbJob.Text;
            var url = this.txbAddress.Text;
            var method = this.comboBoxMethod.Text;
            var parameters = this.txbParameters.Text;
            var contentType = this.cmbContentType.Text;
            var cron = this.txbCron.Text;
            var isAuthentication = this.cbIsOData.Checked;
            var userName = this.txbUserName.Text;
            var password = this.txbPassword.Text;
            var description = this.txbDescription.Text;
            var groupName = this.txbGroupName.Text;

            if(string.IsNullOrEmpty(methodName)) {
                MessageBoxEx.Show(this, "Method name is required and unique", "Remind Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(string.IsNullOrEmpty(triggerName)) {
                MessageBoxEx.Show(this, "Trigger name is required and unique", "Remind Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(string.IsNullOrEmpty(jobName)) {
                MessageBoxEx.Show(this, "JOB identification is required and unique!", "Remind Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(string.IsNullOrEmpty(url)) {
                MessageBoxEx.Show(this, "URL address is required!", "Remind Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(string.IsNullOrEmpty(method)) {
                MessageBoxEx.Show(this, "Method is Required!", "Remind Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(string.IsNullOrEmpty(groupName)) {
                MessageBoxEx.Show(this, "Group name is Required!", "Remind Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(string.IsNullOrEmpty(contentType)) {
                MessageBoxEx.Show(this, "Content-Type is required!", "Remind Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(string.IsNullOrEmpty(cron)) {
                MessageBoxEx.Show(this, "Cron expression is required!", "Remind Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!Utils.IsValidExpression(cron)) {
                MessageBoxEx.Show(this, "Cron expression is not valid!", "Remind Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(isAuthentication) {
                if(string.IsNullOrEmpty(userName)) {
                    MessageBoxEx.Show(this, "Username is required when authentication is selected！", "Remind Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(string.IsNullOrEmpty(password)) {
                    MessageBoxEx.Show(this, "Password is required when authentication is selected", "Remind Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if(!rbWebService.Checked && !rbRestful.Checked) {
                MessageBoxEx.Show(this, "Webservice or restful is required", "Remind Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ruleConfig = new RuleConfig();
            ruleConfig.ServiceName = methodName;
            ruleConfig.Cron = cron;
            ruleConfig.Description = description;
            ruleConfig.TriggerName = triggerName;
            ruleConfig.JobName = jobName;
            ruleConfig.Method = method;
            ruleConfig.PostBody = parameters;
            ruleConfig.ContentType = contentType;
            ruleConfig.IsAuthentication = isAuthentication ? 1 : 0;
            ruleConfig.UserName = userName;
            ruleConfig.Password = password;
            ruleConfig.GroupName = groupName;
            ruleConfig.Address = url;
            ruleConfig.Status = (int)BasicStatus.有效;
            ruleConfig.RunStatus = (int)RunStatus.停用;
            ruleConfig.IsWebService = rbWebService.Checked ? (int)YesOrNo.是 : (int)YesOrNo.否;
            this.IsLoading = true;
            var msg = ServiceUtils.InsertRule(ruleConfig);
            MessageBoxEx.Show(this, msg.Message);
            this.IsLoading = true;
        }

        private void cbIsOData_Click(object sender, EventArgs e) {
            this.txbUserName.ReadOnly = !this.cbIsOData.Checked;
            this.txbPassword.ReadOnly = !this.cbIsOData.Checked;
            this.lblUserName.ForeColor = !this.cbIsOData.Checked ? Color.Black : Color.Red;
            this.lblPassword.ForeColor = !this.cbIsOData.Checked ? Color.Black : Color.Red;
            this.txbUserName.Text = this.cbIsOData.Checked ? this.txbUserName.Text : string.Empty;
            this.txbPassword.Text = this.cbIsOData.Checked ? this.txbPassword.Text : string.Empty;
        }

        private void btnTest_Click(object sender, EventArgs e) {
            var methodName = this.txbMethod.Text;
            var triggerName = this.txbTrigger.Text;
            var jobName = this.txbJob.Text;
            var url = this.txbAddress.Text;
            var method = this.comboBoxMethod.Text;
            var parameters = this.txbParameters.Text;
            var contentType = this.cmbContentType.Text;
            var cron = this.txbCron.Text;
            var isAuthentication = this.cbIsOData.Checked;
            var userName = this.txbUserName.Text;
            var password = this.txbPassword.Text;
            var description = this.txbDescription.Text;
            var groupName = this.txbGroupName.Text;

            if(string.IsNullOrEmpty(methodName)) {
                MessageBoxEx.Show(this, "Method name is required and unique", "Remind Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(string.IsNullOrEmpty(triggerName)) {
                MessageBoxEx.Show(this, "Trigger name is required and unique", "Remind Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(string.IsNullOrEmpty(jobName)) {
                MessageBoxEx.Show(this, "JOB identification is required and unique!", "Remind Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(string.IsNullOrEmpty(url)) {
                MessageBoxEx.Show(this, "URL address is required!", "Remind Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(string.IsNullOrEmpty(method)) {
                MessageBoxEx.Show(this, "Method is Required!", "Remind Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(string.IsNullOrEmpty(groupName)) {
                MessageBoxEx.Show(this, "Group name is Required!", "Remind Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(string.IsNullOrEmpty(contentType)) {
                MessageBoxEx.Show(this, "Content-Type is required!", "Remind Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(string.IsNullOrEmpty(cron)) {
                MessageBoxEx.Show(this, "Cron expression is required!", "Remind Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!Utils.IsValidExpression(cron)) {
                MessageBoxEx.Show(this, "Cron expression is not valid!", "Remind Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(isAuthentication) {
                if(string.IsNullOrEmpty(userName)) {
                    MessageBoxEx.Show(this, "Username is required when authentication is selected！", "Remind Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(string.IsNullOrEmpty(password)) {
                    MessageBoxEx.Show(this, "Password is required when authentication is selected", "Remind Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if(!rbWebService.Checked && !rbRestful.Checked) {
                MessageBoxEx.Show(this, "Webservice or restful is required", "Remind Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ruleConfig = new RuleConfig();
            ruleConfig.Cron = cron;
            ruleConfig.Description = description;
            ruleConfig.TriggerName = triggerName;
            ruleConfig.JobName = jobName;
            ruleConfig.Method = method;
            ruleConfig.PostBody = parameters;
            ruleConfig.ContentType = contentType;
            ruleConfig.IsAuthentication = isAuthentication ? 1 : 0;
            ruleConfig.UserName = userName;
            ruleConfig.Password = password;
            ruleConfig.GroupName = groupName;
            ruleConfig.Address = url;
            ruleConfig.RunStatus = (int) RunStatus.停用;
            ruleConfig.Status = (int)BasicStatus.有效;
            ruleConfig.IsWebService = rbWebService.Checked ? (int)YesOrNo.是 : (int)YesOrNo.否;
            var msg = HttpUtils.PostWebServiceWithoutCredential(ruleConfig.Address, ruleConfig.PostBody);
            MessageBoxEx.Show(this, msg.Message, "Remind Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
