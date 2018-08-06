using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Raise.Monitor.Controls;
using Raise.Monitor.Tools;
using Sunlight.Dispatch.UI;

namespace Raise.Monitor {
    public partial class MainForm : BaseFrm {
        public MainForm() {
            InitializeComponent();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e) {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e) {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach(Form childForm in MdiChildren) {
                childForm.Close();
            }
        }

        private void tsbInsert_Click(object sender, EventArgs e) {
            var frm = new RuleConfigInsertFrm();
            frm.MdiParent = this;
            frm.EditSubmitted += Frm_EditSubmitted;
            frm.Show();
        }

        private void Frm_EditSubmitted(object sender, Sunlight.Dispatch.UI.Extensions.SubmittedEventArgs e) {
            e.Close();
        }

        private void tsbSearch_Click(object sender, EventArgs e) {
            var frm = new RuleConfigFrm();
            frm.MdiParent = this;
            frm.EditSubmitted += Frm_EditSubmitted;
            frm.Show();
        }

        private void tsbLogInfo_Click(object sender, EventArgs e) {
            var frm = new LogInformationFrm();
            frm.MdiParent = this;
            frm.EditSubmitted += Frm_EditSubmitted;
            frm.Show();
        }

        private void toolStripButtonStartService_Click(object sender, EventArgs e) {
            var services = SettingUtils.ServiceNames;
            if(services == null || !services.Any()) {
                MessageBoxEx.Show(this, "没有找到本应用管理的任何服务，请检查配置是否正确？", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.IsLoading = true;
            var msg = new List<string>();
            services.ForEach(data => {
                msg.Add(Utils.StartWindowsService(data.ServiceName).Message);
            });

            if(msg.Any())
                MessageBoxEx.Show(this, $"{string.Join("\r\n", msg)}", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.IsLoading = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e) {
            var services = SettingUtils.ServiceNames;
            if(services == null || !services.Any()) {
                MessageBoxEx.Show(this, "没有找到本应用管理的任何服务，请检查配置是否正确？", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.IsLoading = true;
            var msg = new List<string>();
            services.ForEach(data => {
                msg.Add(Utils.StopWindowsService(data.ServiceName).Message);
            });

            if(msg.Any())
                MessageBoxEx.Show(this, $"{string.Join("\r\n", msg)}", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.IsLoading = false;
        }

        private void tsbOtherLog_Click(object sender, EventArgs e) {
            var frm = new SystemLogFrm();
            frm.MdiParent = this;
            frm.EditSubmitted += Frm_EditSubmitted;
            frm.Show();
        }
    }
}
