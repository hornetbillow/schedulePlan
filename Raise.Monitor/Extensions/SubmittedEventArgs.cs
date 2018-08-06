using System;
using System.Windows.Forms;

namespace Sunlight.Dispatch.UI.Extensions {
    public class SubmittedEventArgs : EventArgs {
        private readonly Form window;
        public void Close() {
            if(window != null)
                this.window.Close();
        }
        public SubmittedEventArgs(Form crrentWindow) {
            window = crrentWindow;
        }
    }
}
