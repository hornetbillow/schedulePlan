using System;
using System.Drawing;
using System.Windows.Forms;
using Raise.Monitor.Model;
using Raise.Monitor.Service;
using Raise.Monitor.Tools;
using Sunlight.Dispatch.UI.Controls;
using System.Linq;

namespace Raise.Monitor {
    public partial class LogInformationFrm : BaseFrm {
        public LogInformationFrm() {
            InitializeComponent();
            this.Load += InterfaceLogFrm_Load;
        }

        private void InterfaceLogFrm_Load(object sender, EventArgs e) {
            this.SetComboBoxSource(this.comboBoxMethod, GlobalVar.METHOD_TYPE);
            this.SetComboBoxSource(this.cmbDispachStatus, GlobalVar.MESSAGE_STATUS);
            this.SetGridViewComboBoxSource(this.DsplayStatus, GlobalVar.MESSAGE_STATUS);
            this.SetGridViewComboBoxSource(this.comboBoxIsWebService, GlobalVar.YES_OR_NO);
            this.pagerControl.OnPageChanged += this.PagerControl_OnPageChanged;
            this.OnControlCreated(this.dataGridView, this.pagerControl);
            this.pagerControl.PageSize = 20;
            this.txbKeyWords.KeyDown += TxbCommon_KeyDown;
            this.txbMethod.KeyDown += TxbCommon_KeyDown;
            this.txbKeyWords.KeyDown += TxbCommon_KeyDown;
            this.dataGridView.RowPostPaint += this.DataGridView_RowPostPaint;
            this.dataGridView.CellFormatting += DgvLogInfo_CellFormatting;
            this.contextMenuStrip.ItemClicked += ContextMenuStrip_ItemClicked;
            this.dataGridView.CellMouseDown += DataGridView_CellMouseDown;
            this.dataGridView.Columns[7].Frozen = true;
        }

        private void DataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            if(e.Button == MouseButtons.Right) {
                if(e.RowIndex >= 0) {
                    //若行已是选中状态就不再进行设置
                    if(dataGridView.Rows[e.RowIndex].Selected == false) {
                        dataGridView.ClearSelection();
                        dataGridView.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if(dataGridView.SelectedRows.Count == 1) {
                        dataGridView.CurrentCell = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    //弹出操作菜单
                    this.contextMenuStrip.Show(MousePosition.X, MousePosition.Y);
                }
            }

        }

        private void ContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            var selectedItems = this.dataGridView.SelectedRows;
            if(selectedItems.Count <= 0)
                return;
            var monitorLogRecord = selectedItems[0].DataBoundItem as MonitorLogRecordConfigView;
            if(monitorLogRecord == null)
                return;
            switch(e.ClickedItem.Name) {
                case GlobalVar.COPY_MESSAGE:
                    Clipboard.SetText(monitorLogRecord.Message);
                    break;
                case GlobalVar.COPY_RESPONSEMESSAGE:
                    Clipboard.SetText(monitorLogRecord.ResponseMessage);
                    break;
                case GlobalVar.COPY_SERVICENAME:
                    Clipboard.SetText(monitorLogRecord.ServiceName);
                    break;
                case GlobalVar.COPY_STATUS_CODE:
                    Clipboard.SetText(monitorLogRecord.StatusCode.ToString());
                    break;
                case GlobalVar.COPY_STATUS_CODE_DESCRIPTION:
                    Clipboard.SetText(monitorLogRecord.StatusCodeDescription);
                    break;
            }
        }

        private void DgvLogInfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if(e.ColumnIndex == 6 && e.Value != null && !string.IsNullOrEmpty(e.Value.ToString())) {
                e.Value = Convert.ToDateTime(e.Value.ToString()).ToString("yyyy-MM-dd HH:mm:ss");
            }
        }

        private void TxbCommon_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter)
                this.SearchGridView(1);
        }

        private void SetGridViewComboBoxSource(DataGridViewComboBoxColumn comboBox, string name) {
            var keyValueItems = ServiceUtils.GetKeyValueItems(name);
            comboBox.DataSource = keyValueItems;
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";
        }

        private void SetComboBoxSource(ComboBox comboBox, string name) {
            var keyValueItems = ServiceUtils.GetKeyValueItems(name);
            comboBox.DataSource = keyValueItems;
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";
        }

        protected override void LoadInitLocation() {
            base.LoadInitLocation();
            this.dateTimePickerBegin.Value = DateTime.Now.AddDays(-7);
            this.dateTimePickerEnd.Value = DateTime.Now.AddDays(1);
            this.dataGridView.Height = this.Height - this.gbCondition.Height - this.pageControlPanel.Height - 90;
            this.dataGridView.Width = this.Width - 50;
            this.dataGridView.ScrollBars = ScrollBars.Both;
            this.pageControlPanel.Location = new Point(this.dataGridView.Location.X, this.dataGridView.Location.Y + this.dataGridView.Height);
            this.pageControlPanel.Width = this.dataGridView.Width;
            var locationX = this.dataGridView.Width - this.pagerControl.Width - 50;
            this.pagerControl.Location = new Point(this.pageControlPanel.Location.X + locationX, pagerControl.Location.Y);
        }

        private void PagerControl_OnPageChanged(object sender, PageControlEvemtArgs e) {
            this.SearchGridView(e.PageIndex);
        }

        private void SearchGridView(int pageIndex = 1) {
            var methodName = this.txbMethod.Text;
            string requestType = null;
            var keyWords = this.txbKeyWords.Text;
            var dispachStatus = this.comboBoxMethod.SelectedValue as int?;
            var beginTime = this.dateTimePickerBegin.Value;
            var endTime = this.dateTimePickerEnd.Value;
            var keyValue = this.cmbDispachStatus.SelectedItem as KeyValueItem;

            if(this.cmbDispachStatus.SelectedItem != null && keyValue != null && keyValue.Key > -1) {
                requestType = keyValue.Value;
            }
            this.IsLoading = true;
            var pageData = ServiceUtils.GetConfigRulesWithLogs(pageIndex, keyWords, requestType, methodName, dispachStatus, beginTime, endTime);
            this.dataGridView.DataSource = pageData.Data;
            this.pagerControl.PageIndex = pageIndex;
            this.pagerControl.DrawControl(pageData.Total ?? 0);
            this.IsLoading = false;
        }

        private void btnSearch_Click_1(object sender, EventArgs e) {
            SearchGridView();
        }
    }
}
