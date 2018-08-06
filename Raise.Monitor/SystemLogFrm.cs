using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Raise.Monitor.Extension;
using Raise.Monitor.Model;
using Raise.Monitor.Service;
using Sunlight.Dispatch.UI.Controls;
using LogLevel = Raise.Monitor.Tools.LogLevel;

namespace Raise.Monitor {
    public partial class SystemLogFrm : BaseFrm {
        public SystemLogFrm() {
            InitializeComponent();
            this.Load += InterfaceLogFrm_Load;
        }

        private void InterfaceLogFrm_Load(object sender, EventArgs e) {
            this.pagerControl.OnPageChanged += this.PagerControl_OnPageChanged;
            this.OnControlCreated(this.dataGridView, this.pagerControl);
            this.pagerControl.PageSize = 20;
            this.txbKeyWords.KeyDown += TxbCommon_KeyDown;
            this.txbCallsite.KeyDown += TxbCommon_KeyDown;
            this.txbKeyWords.KeyDown += TxbCommon_KeyDown;
            this.dataGridView.RowPostPaint += this.DataGridView_RowPostPaint;
            this.dataGridView.CellFormatting += DgvLogInfo_CellFormatting;
            this.dataGridView.SelectionChanged += DataGridView_SelectionChanged1;

            var logLevels = new List<KeyValuePair>();
            logLevels.Add(new KeyValuePair {
                Key = -1,
                Value = "不限"
            });
            var values = Enum.GetValues(typeof(LogLevel));
            foreach(int value in values) {
                logLevels.Add(new KeyValuePair {
                    Key = value,
                    Value = Enum.GetName(typeof(LogLevel), value)
                });
            }
            this.cmbLogLevel.DataSource = logLevels;
            this.cmbLogLevel.DisplayMember = "Value";
            this.cmbLogLevel.ValueMember = "Key";
        }

        private void DataGridView_SelectionChanged1(object sender, EventArgs e) {
            if(this.dataGridView.SelectedRows.Count <= 0)
                return;
            var sysLog = this.dataGridView.SelectedRows[0].DataBoundItem as SystemLog;
            if(sysLog == null)
                return;
            this.tsslInfo.Text = sysLog.StackTrace;
        }

        private void DgvLogInfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if(e.ColumnIndex == dataGridView.Columns["createTimeColumn"]?.Index && !string.IsNullOrEmpty(e.Value?.ToString())) {
                e.Value = Convert.ToDateTime(e.Value.ToString()).ToString("yyyy-MM-dd HH:mm:ss");
            }
        }

        private void TxbCommon_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter)
                this.SearchGridView(1);
        }

        protected override void LoadInitLocation() {
            base.LoadInitLocation();
            this.dateTimePickerBegin.Value = DateTime.Now.AddDays(-7);
            this.dateTimePickerEnd.Value = DateTime.Now.AddDays(1);
            this.dataGridView.Height = this.Height - this.gbCondition.Height - this.pageControlPanel.Height - 90;
            this.dataGridView.Width = this.Width - 50;
            this.dataGridView.ScrollBars = ScrollBars.Vertical;
            this.pageControlPanel.Location = new Point(this.dataGridView.Location.X, this.dataGridView.Location.Y + this.dataGridView.Height);
            this.pageControlPanel.Width = this.dataGridView.Width;
            var locationX = this.dataGridView.Width - this.pagerControl.Width - 50;
            this.pagerControl.Location = new Point(this.pageControlPanel.Location.X + locationX, pagerControl.Location.Y);
        }

        private void PagerControl_OnPageChanged(object sender, PageControlEvemtArgs e) {
            this.SearchGridView(e.PageIndex);
        }

        private void SearchGridView(int pageIndex = 1) {
            var callsite = this.txbCallsite.Text;
            var keyWords = this.txbKeyWords.Text;
            var beginTime = this.dateTimePickerBegin.Value;
            var endTime = this.dateTimePickerEnd.Value;
            var keyValue = (KeyValuePair)this.cmbLogLevel.SelectedItem;

            this.IsLoading = true;
            var pageData = ServiceUtils.GetSystemLogs(pageIndex, keyWords, callsite, keyValue.Key > -1 ? keyValue.Value : string.Empty, beginTime, endTime);
            this.dataGridView.DataSource = pageData.Data;
            this.pagerControl.PageIndex = pageIndex;
            this.pagerControl.DrawControl(pageData.Total ?? 0);
            this.IsLoading = false;
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            SearchGridView();
        }
    }
}
