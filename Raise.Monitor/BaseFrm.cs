using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Sunlight.Dispatch.UI;
using Sunlight.Dispatch.UI.Controls;
using Sunlight.Dispatch.UI.Extensions;
using EditState = Raise.Monitor.Extensions.EditState;

namespace Raise.Monitor {
    //[DesignerCategory("BaseFrm")]
    //[DesignTimeVisible(false)]
    public class BaseFrm : Form, INotifyPropertyChanged {
        private bool isInitialize;
        private bool isLoading;
        private readonly CommonRegister register = new CommonRegister();
        public event EventHandler<SubmittedEventArgs> EditSubmitted; //该事件用户保存后，返回主界面之后的处理
        public event EventHandler<SubmittedEventArgs> ExtendEvent;

        /// <summary>
        /// 注册控件，标记为数字类型的控件
        /// </summary>
        public CommonRegister Register {
            get {
                return this.register;
            }
        }

        protected virtual void OnControlCreated(DataGridView dataGridView, PagerControl pagerControl) {
            if(dataGridView != null) {
                dataGridView.ReadOnly = true;
                dataGridView.AutoGenerateColumns = false;
                dataGridView.AllowUserToAddRows = false;
                dataGridView.AllowUserToDeleteRows = false;
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView.RowPostPaint += DataGridView_RowPostPaint;

                dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView.SelectionChanged += this.DataGridView_SelectionChanged;
                dataGridView.MultiSelect = false;
            }
            this.SizeChanged += this.CurrentForm_SizeChanged;
            if(pagerControl != null) {
                pagerControl.PageSize = 10;
                pagerControl.PageIndex = 0;
                pagerControl.DrawControl(0);
            }
        }

        protected void DataGridView_SelectionChanged(object sender, EventArgs e) {
            var dataGridView = sender as DataGridView;
            if(dataGridView == null)
                return;
            SetItemIsSelected(dataGridView, dataGridView.CurrentRow);
        }

        private void SetItemIsSelected(DataGridView dataGridView, DataGridViewRow row) {
            foreach(DataGridViewRow dataGridViewRow in dataGridView.Rows) {
                if(row.Index == dataGridViewRow.Index) {
                    dataGridViewRow.Cells[0].Value = true;
                    continue;
                }
                dataGridViewRow.Cells[0].Value = false;
            }
        }

        private void CurrentForm_SizeChanged(object sender, EventArgs e) {
            this.LoadInitLocation();
        }

        protected virtual void LoadInitLocation() {

        }

        protected EditState EditState {
            get;
            set;
        }

        /// <summary>
        /// 是否启用Loading
        /// </summary>
        public bool IsLoading {
            get {
                return this.isLoading;
            }
            set {
                this.isLoading = value;
                this.OnPropertyChanged();
            }
        }

        /// <summary>
        /// 是否重置基类的ESC退出页面功能
        /// </summary>
        protected virtual bool ResetEscFunction {
            get {
                return false;
            }
        }

        /// <summary>
        /// 清理内存的垃圾
        /// </summary>
        protected override void Dispose(bool disposing) {
            GC.Collect();
            base.Dispose(disposing);
        }

        /// <summary>
        /// 该方法的内容只在第一次loaded之后执行
        /// </summary>
        private void Initialize() {
            foreach(Control control in this.Controls) {
                control.KeyDown -= this.control_KeyDown;
                control.KeyDown += this.control_KeyDown;
            }

            this.PropertyChanged += this.BaseFrm_PropertyChanged;
        }

        private void BaseFrm_PropertyChanged(object sender, PropertyChangedEventArgs e) {
            switch(e.PropertyName) {
                case "IsLoading":
                    if(!this.IsLoading)
                        Cursor.Current = Cursors.Default;
                    if(this.IsLoading)
                        Cursor.Current = Cursors.WaitCursor;
                    break;
            }
        }

        private void control_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Escape)
                this.Close();
            var textBox = sender as TextBox;
            if(textBox != null) {
                if(e.Modifiers == Keys.Control && e.KeyCode == Keys.A) {
                    textBox.SelectAll();
                }
            }
        }

        /// <summary>
        /// 重绘序列号
        /// </summary>
        protected void DataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e) {
            var dataGridView = sender as DataGridView;
            if(dataGridView == null)
                return;
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Y, dataGridView.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dataGridView.RowHeadersDefaultCellStyle.Font, rectangle, dataGridView.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        public BaseFrm() {
            this.Load -= this.BaseFrm_Load;
            this.Load += this.BaseFrm_Load;
        }

        /// <summary>
        /// 唤醒EditSubmitted事件
        /// </summary>
        protected void RasieEditSubmitted() {
            if(EditSubmitted != null)
                EditSubmitted.Invoke(this, new SubmittedEventArgs(this));
        }

        /// <summary>
        /// 唤醒ExtendEvent事件
        /// </summary>
        protected void RasieExtendEvent(object obj) {
            if(ExtendEvent != null)
                ExtendEvent.Invoke(obj, new SubmittedEventArgs(this));
        }

        private void BaseFrm_Load(object sender, EventArgs e) {
            if(!string.IsNullOrEmpty(this.Title))
                this.Text = this.Title;
            this.LoadInitLocation();
            if(!this.isInitialize) {
                isInitialize = true;
                Initialize();
            }
        }

        /// <summary>
        /// 标题设置
        /// </summary>
        protected virtual string Title {
            get;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
