using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Raise.Monitor.Tools;

namespace Raise.Monitor {
    public class CommonRegister {
        /// <summary>
        /// 注册允许输入小数，数字的控件
        /// </summary>
        /// <param name="controls">注册的TextBox控件</param>
        public void RegisterNumerical(TextBox[] controls) {
            if(controls != null && controls.Any()) {
                foreach(var control in controls) {
                    control.KeyPress -= this.textBoxNumerical_KeyPress;
                    control.KeyPress += this.textBoxNumerical_KeyPress;

                    control.TextChanged -= this.txtBoxCommon_TextChanged;
                    control.TextChanged += this.txtBoxCommon_TextChanged;
                }
            }
        }

        /// <summary>
        /// 注册允许输入整数数字的控件
        /// </summary>
        /// <param name="controls">注册的TextBox控件</param>
        public void RegisterNumber(TextBox[] controls) {
            if(controls != null && controls.Any()) {
                foreach(var control in controls) {
                    control.KeyPress -= this.textBoxNumber_KeyPress;
                    control.KeyPress += this.textBoxNumber_KeyPress;

                    control.TextChanged -= this.txtBoxCommon_TextChanged;
                    control.TextChanged += this.txtBoxCommon_TextChanged;
                }
            }
        }

        private void textBoxNumerical_KeyPress(object sender, KeyPressEventArgs e) {
            if((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13 && e.KeyChar != 45 && e.KeyChar != 46) {
                e.Handled = true;
            }

            //输入为负号时，只能输入一次且只能输入一次
            if(e.KeyChar == 45 && (((TextBox)sender).SelectionStart != 0 || ((TextBox)sender).Text.IndexOf("-", StringComparison.Ordinal) >= 0)) e.Handled = true;
            if(e.KeyChar == 46 && ((TextBox)sender).Text.IndexOf(".", StringComparison.Ordinal) >= 0) e.Handled = true;
        }

        private void textBoxNumber_KeyPress(object sender, KeyPressEventArgs e) {
            //IsNumber判断按键是否是数字
            //char 8是退格键值，可以允许用户敲击退格对数字进行修改
            if(!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8) {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 防止输入0开头的数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxCommon_TextChanged(object sender, EventArgs e) {
            var textBox = sender as TextBox;
            if(textBox == null)
                return;
            if(!string.IsNullOrEmpty(textBox.Text) && RegexUtils.IsNumber(textBox.Text)) {
                textBox.Text = Convert.ToInt32(textBox.Text).ToString(CultureInfo.InvariantCulture);
            }
        }
    }
}
