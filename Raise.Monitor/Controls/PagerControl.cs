using System;
using System.Windows.Forms;

namespace Sunlight.Dispatch.UI.Controls {
    public partial class PagerControl : UserControl {
        public PagerControl() {
            InitializeComponent();
        }

        private int pageIndex = 1;
        /// <summary>
        /// 当前页面
        /// </summary>
        public virtual int PageIndex {
            get {
                return pageIndex;
            }
            set {
                pageIndex = value;
            }
        }

        private int pageSize = 50;
        /// <summary>
        /// 每页记录数
        /// </summary>
        public virtual int PageSize {
            get {
                return pageSize;
            }
            set {
                pageSize = value;
            }
        }

        private int recordCount = 0;
        /// <summary>
        /// 总记录数
        /// </summary>
        public virtual int RecordCount {
            get {
                return recordCount;
            }
            set {
                recordCount = value;
            }
        }

        private int pageCount = 0;
        /// <summary>
        /// 总页数
        /// </summary>
        public int PageCount {
            get {
                if(pageSize != 0) {
                    pageCount = GetPageCount();
                }
                return pageCount;
            }
        }

        private string jumpText;
        /// <summary>
        /// 跳转按钮文本
        /// </summary>
        public string JumpText {
            get {
                if(string.IsNullOrEmpty(jumpText)) {
                    jumpText = "Go";
                }
                return jumpText;
            }
            set {
                jumpText = value;
            }
        }

        public event EventHandler<PageControlEvemtArgs> OnPageChanged;

        private void SetFormCtrEnabled() {
            lnkFirst.Enabled = true;
            lnkPrev.Enabled = true;
            lnkNext.Enabled = true;
            lnkLast.Enabled = true;
        }

        /// <summary>
        /// 计算总页数
        /// </summary>
        /// <returns></returns>
        private int GetPageCount() {
            if(PageSize == 0) {
                return 0;
            }
            int pageCount = RecordCount / PageSize;
            if(RecordCount % PageSize == 0) {
                pageCount = RecordCount / PageSize;
            } else {
                pageCount = RecordCount / PageSize + 1;
            }
            return pageCount;
        }
        /// <summary>
        /// 外部调用
        /// </summary>
        public void DrawControl(int count) {
            recordCount = count;
            DrawControl(false);
        }
        /// <summary>
        /// 页面控件呈现
        /// </summary>
        private void DrawControl(bool callEvent) {
            lblCurrentPage.Text = PageIndex.ToString();
            lblPageCount.Text = PageCount.ToString();
            lblTotalCount.Text = RecordCount.ToString();
            txtPageSize.Text = PageSize.ToString();

            if(callEvent) {
                OnPageChanged?.Invoke(this, new PageControlEvemtArgs(this.PageSize, this.pageIndex));//当前分页数字改变时，触发委托事件
            }
            SetFormCtrEnabled();
            if(PageCount == 1)//有且仅有一页
            {
                lnkFirst.Enabled = false;
                lnkPrev.Enabled = false;
                lnkNext.Enabled = false;
                lnkLast.Enabled = false;
            } else if(PageIndex == 1)//第一页
              {
                lnkFirst.Enabled = false;
                lnkPrev.Enabled = false;
            } else if(PageIndex == PageCount)//最后一页
              {
                lnkNext.Enabled = false;
                lnkLast.Enabled = false;
            }
        }

        private void lnkFirst_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            PageIndex = 1;
            DrawControl(true);
        }

        private void lnkPrev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            PageIndex = Math.Max(1, PageIndex - 1);
            DrawControl(true);
        }

        private void lnkNext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            PageIndex = Math.Min(PageCount, PageIndex + 1);
            DrawControl(true);
        }

        private void lnkLast_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            PageIndex = PageCount;
            DrawControl(true);
        }
        
        /// <summary>
        /// 分页属性改变了。
        /// </summary>
        private void txtPageSize_TextChanged(object sender, EventArgs e) {
            int num = 0;
            if(!int.TryParse(txtPageSize.Text.Trim(), out num) || num <= 0) {
                num = 100;
                txtPageSize.Text = "100";
            }
            pageSize = num;
        }
    }
}