using System;

namespace Sunlight.Dispatch.UI.Controls {
    public class PageControlEvemtArgs : EventArgs {
        public int PageIndex {
            get;
        }
        public int PageSize {
            get;
        }
        public PageControlEvemtArgs(int pageSize, int pageIndex) {

            this.PageSize = pageSize;
            this.PageIndex = pageIndex;
        }
    }
}