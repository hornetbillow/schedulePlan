using System;
using System.Threading;
using System.Windows.Forms;
using Raise.Monitor.Tools;

namespace Raise.Monitor {
    public static class Program {
        [STAThread]
        static void Main() {
            //设置应用程序处理异常方式：ThreadException处理  
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            //处理UI线程异常  
            Application.ThreadException += Application_ThreadException;
            //处理非UI线程异常  
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.ApplicationExit += Application_ApplicationExit;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }


        private static void Application_ApplicationExit(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e) {
            string str = LoggerUtils.GetExceptionMsg(e.Exception, e.ToString());
            MessageBox.Show(str, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LoggerUtils.Error(str);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e) {
            string str = LoggerUtils.GetExceptionMsg(e.ExceptionObject as Exception, e.ToString());
            MessageBox.Show(str, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LoggerUtils.Error(str);
        }
    }
}
