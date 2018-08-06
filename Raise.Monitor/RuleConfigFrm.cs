using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Raise.Monitor.Model;
using Raise.Monitor.Service;
using Raise.Monitor.Tools;
using Sunlight.Dispatch.UI.Controls;
using System.Linq;
using Raise.Monitor.Controls;
using Newtonsoft.Json;

namespace Raise.Monitor {
    public partial class RuleConfigFrm : BaseFrm {
        public RuleConfigFrm() {
            InitializeComponent();
            this.Load += InterfaceLogFrm_Load;
        }

        private void InterfaceLogFrm_Load(object sender, EventArgs e) {
            this.SetComboBoxSource(this.cmbRequestType, GlobalVar.METHOD_TYPE);
            this.SetComboBoxSource(this.cmbRunStatus, GlobalVar.RUN_STATUS);
            this.SetComboBoxSource(this.comboBoxStatus, GlobalVar.BASIC_STATUS);
            this.pagerControl.OnPageChanged += this.PagerControl_OnPageChanged;
            this.OnControlCreated(this.dataGridRule, this.pagerControl);
            this.pagerControl.PageSize = 20;
            this.txbKeyWords.KeyDown += TxbCommon_KeyDown;
            this.txbServiceName.KeyDown += TxbCommon_KeyDown;
            this.txbKeyWords.KeyDown += TxbCommon_KeyDown;
            this.dataGridRule.RowPostPaint += this.DataGridView_RowPostPaint;
            this.dataGridRule.CellMouseDown += DataGridView_CellMouseDown;
            this.dataGridRule.Columns[5].Frozen = true;
            this.dataGridRule.ScrollBars = ScrollBars.Both;
        }

        private void DataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            if(e.Button == MouseButtons.Right) {
                if(e.RowIndex >= 0) {
                    //若行已是选中状态就不再进行设置
                    if(dataGridRule.Rows[e.RowIndex].Selected == false) {
                        dataGridRule.ClearSelection();
                        dataGridRule.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if(dataGridRule.SelectedRows.Count == 1) {
                        dataGridRule.CurrentCell = dataGridRule.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    //弹出操作菜单
                    //this.contextMenuStrip.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void TxbCommon_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter)
                this.SearchGridView();
        }

        private string ConvertKeyToValue(string name, int key) {
            //内部有缓存机制，不用考虑性能问题
            var keyValueItems = ServiceUtils.GetKeyValueItems(name);
            var keyValue = keyValueItems.FirstOrDefault(data => data.Key == key);
            if(keyValue == null)
                return string.Empty;
            return keyValue.Value;
        }

        private void SetComboBoxSource(ComboBox comboBox, string name) {
            var keyValueItems = ServiceUtils.GetKeyValueItems(name);
            comboBox.DataSource = keyValueItems;
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";
        }

        protected override void LoadInitLocation() {
            base.LoadInitLocation();
            this.dataGridRule.Height = this.Height - this.gbCondition.Height - this.pageControlPanel.Height - 90;
            this.dataGridRule.Width = this.Width - 50;
            this.pageControlPanel.Location = new Point(this.dataGridRule.Location.X, this.dataGridRule.Location.Y + this.dataGridRule.Height);
            this.pageControlPanel.Width = this.dataGridRule.Width;
            var locationX = this.dataGridRule.Width - this.pagerControl.Width - 50;
            this.pagerControl.Location = new Point(this.pageControlPanel.Location.X + locationX, pagerControl.Location.Y);
        }

        private void PagerControl_OnPageChanged(object sender, PageControlEvemtArgs e) {
            this.SearchGridView(e.PageIndex);
        }

        private void SearchGridView(int pageIndex = 1) {
            var methodName = this.txbServiceName.Text;
            string requestType = null;
            int runSttus = default(int);
            int status = default(int);
            var keyWords = this.txbKeyWords.Text;
            var runStatusKeyValue = this.cmbRunStatus.SelectedItem as KeyValueItem;
            var requestTypeKeyValue = this.cmbRequestType.SelectedItem as KeyValueItem;
            var statusKeyValue = this.comboBoxStatus.SelectedItem as KeyValueItem;

            if(runStatusKeyValue != null && runStatusKeyValue.Key > -1) {
                runSttus = runStatusKeyValue.Key;
            }
            if(requestTypeKeyValue != null && requestTypeKeyValue.Key > -1) {
                requestType = requestTypeKeyValue.Value;
            }
            if(statusKeyValue != null && statusKeyValue.Key > -1) {
                status = statusKeyValue.Key;
            }
            this.IsLoading = true;
            var pageData = ServiceUtils.GetConfigRules(pageIndex, keyWords, requestType, methodName, runSttus, status);
            var data = new List<object>();
            foreach(var rule in pageData.Data) {
                var ov = new {
                    rule.Id,
                    rule.Cron,
                    rule.Description,
                    rule.TriggerName,
                    rule.JobName,
                    rule.Method,
                    rule.PostBody,
                    rule.ServiceName,
                    rule.Author,
                    rule.ContentType,
                    IsAuthentication = rule.IsAuthentication == 1 ? "需要认证" : "无需认证",
                    rule.UserName,
                    rule.Password,
                    rule.Address,
                    rule.GroupName,
                    Status = ConvertKeyToValue(GlobalVar.BASIC_STATUS, rule.Status),
                    RunStatus = ConvertKeyToValue(GlobalVar.RUN_STATUS, rule.RunStatus),
                    IsWebService = rule.IsWebService == 1 ? "是" : "否",
                    rule.UniqueCode
                };
                data.Add(ov);
            }
            this.dataGridRule.DataSource = data;
            this.pagerControl.PageIndex = pageIndex;
            this.pagerControl.DrawControl(pageData.Total ?? 0);
            this.IsLoading = false;
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            SearchGridView();
        }

        private void toolStripButtonStart_Click(object sender, EventArgs e) {
            var selectedItems = this.dataGridRule.SelectedRows;
            if(selectedItems.Count < 0) {
                MessageBoxEx.Show(this, "请选择要启用的数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(MessageBoxEx.Show(this, "确定要启用所选择的数据吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) ==
                DialogResult.OK) {
                var ruleConfig = JsonConvert.DeserializeObject<RuleConfigView>(JsonConvert.SerializeObject(selectedItems[0].DataBoundItem));
                ServiceUtils.SetRuleConfigRunStatus(ruleConfig.Id, (int)RunStatus.启用);
                this.SearchGridView();
            }
        }

        private void toolStripButtonStop_Click(object sender, EventArgs e) {
            var selectedItems = this.dataGridRule.SelectedRows;
            if(selectedItems.Count < 0) {
                MessageBoxEx.Show(this, "请选择要停用的数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(MessageBoxEx.Show(this, "确定要停用所选择的数据吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) ==
                DialogResult.OK) {
                var ruleConfig = JsonConvert.DeserializeObject<RuleConfigView>(JsonConvert.SerializeObject(selectedItems[0].DataBoundItem));
                ServiceUtils.SetRuleConfigRunStatus(ruleConfig.Id, (int)RunStatus.停用);
                this.SearchGridView();
            }
        }

        private void tsbAbandon_Click(object sender, EventArgs e) {
            var selectedItems = this.dataGridRule.SelectedRows;
            if(selectedItems.Count < 0) {
                MessageBoxEx.Show(this, "请选择要作废的数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(MessageBoxEx.Show(this, "确定要作废所选择的数据吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) ==
                DialogResult.OK) {
                var ruleConfig = JsonConvert.DeserializeObject<RuleConfigView>(JsonConvert.SerializeObject(selectedItems[0].DataBoundItem));
                ServiceUtils.SetRuleConfigStatus(ruleConfig.Id, (int)BasicStatus.作废);
                this.SearchGridView();
            }
        }

        private void tsbRecovery_Click(object sender, EventArgs e) {
            var selectedItems = this.dataGridRule.SelectedRows;
            if(selectedItems.Count < 0) {
                MessageBoxEx.Show(this, "请选择要恢复的数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(MessageBoxEx.Show(this, "确定要恢复所选择的数据吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) ==
                DialogResult.OK) {
                var ruleConfig = JsonConvert.DeserializeObject<RuleConfigView>(JsonConvert.SerializeObject(selectedItems[0].DataBoundItem));
                ServiceUtils.SetRuleConfigStatus(ruleConfig.Id, (int)BasicStatus.有效);
                this.SearchGridView();
            }
        }

        private void tsbInsert_Click(object sender, EventArgs e) {
            var frm = new RuleConfigInsertFrm();
            frm.MdiParent = this.MdiParent;
            frm.EditSubmitted += Frm_EditSubmitted;
            frm.Show();
        }

        private void Frm_EditSubmitted(object sender, Sunlight.Dispatch.UI.Extensions.SubmittedEventArgs e) {
            e.Close();
        }

        private void tsbDetails_Click(object sender, EventArgs e) {
            var selectedItems = this.dataGridRule.SelectedRows;
            if(selectedItems.Count <= 0) {
                MessageBoxEx.Show(this, "请选择要查看明细的数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Hide();
            var ruleConfig = JsonConvert.DeserializeObject<RuleConfigView>(JsonConvert.SerializeObject(selectedItems[0].DataBoundItem));
            var detailFrm = new RuleConfigDetailFrm();
            detailFrm.SetObjectToDisplay(ruleConfig);
            detailFrm.MdiParent = this.MdiParent;
            detailFrm.Closed += DetailFrm_Closed;
            detailFrm.Show();
        }

        private void DetailFrm_Closed(object sender, EventArgs e) {
            this.Show();
        }

        private void tsbUpdate_Click(object sender, EventArgs e) {
            var selectedItems = this.dataGridRule.SelectedRows;
            if(selectedItems.Count <= 0) {
                MessageBoxEx.Show(this, "请选择要编辑的数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Hide();
            var ruleConfig =
                JsonConvert.DeserializeObject<RuleConfigView>(JsonConvert.SerializeObject(selectedItems[0].DataBoundItem));
            var detailFrm = new RuleConfigEditFrm();
            detailFrm.SetObjectToEdit(ruleConfig.Id);
            detailFrm.MdiParent = this.MdiParent;
            detailFrm.EditSubmitted += DetailFrm_EditSubmitted;
            detailFrm.Closed += DetailFrm_Closed;
            detailFrm.Show();
        }

        private void DetailFrm_EditSubmitted(object sender, Sunlight.Dispatch.UI.Extensions.SubmittedEventArgs e) {
            e.Close();
            this.Show();
        }
    }
}
