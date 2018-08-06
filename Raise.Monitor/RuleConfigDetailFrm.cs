using Raise.Monitor.Model;
using Raise.Monitor.Tools;

namespace Raise.Monitor {
    public partial class RuleConfigDetailFrm : BaseFrm {
        public RuleConfigDetailFrm() {
            InitializeComponent();
        }

        public void SetObjectToDisplay(RuleConfigView ruleConfig) {
            this.cbIsOData.Checked = ruleConfig.IsAuthentication == "需要认证";
            this.comboBoxMethod.Text = ruleConfig.Method;
            this.txbMethod.Text = ruleConfig.ServiceName;
            this.txbTrigger.Text = ruleConfig.TriggerName;
            this.txbJob.Text = ruleConfig.JobName;
            this.txbAddress.Text = ruleConfig.Address;
            this.txbParameters.Text = ruleConfig.PostBody;
            this.txbContentType.Text = ruleConfig.ContentType;
            this.txbCron.Text = ruleConfig.Cron;
            this.rbWebService.Checked = ruleConfig.IsWebService == YesOrNo.是.ToString();
            this.rbRestful.Checked = ruleConfig.IsWebService != YesOrNo.是.ToString();
            this.txbUserName.Text = ruleConfig.UserName;
            this.txbPassword.Text = ruleConfig.Password;
            this.txbDescription.Text = ruleConfig.Description;
            this.txbRunStatus.Text = ruleConfig.RunStatus;
            this.txbStatus.Text = ruleConfig.Status;
            this.txbGroupName.Text = ruleConfig.GroupName;
        }
    }
}
