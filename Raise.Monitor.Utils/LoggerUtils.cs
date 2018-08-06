using System;
using System.Text;
using NLog;

namespace Raise.Monitor.Tools {
    /// <summary>
    /// 日志Utils
    /// </summary>
    public static class LoggerUtils {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public static void Debug(string msg, params object[] args) {
            Logger.Debug(msg, args);
        }

        public static void Info(string msg, params object[] args) {
            Logger.Info(msg, args);
        }

        public static void Trace(string msg, params object[] args) {
            Logger.Trace(msg, args);
        }

        public static void Error(string msg, params object[] args) {
            Logger.Error(msg, args);
        }

        public static void Fatal(string msg, params object[] args) {
            Logger.Fatal(msg, args);
        }

        /// <summary>  
        /// 生成自定义异常消息  
        /// </summary>  
        /// <param name="ex">异常对象</param>  
        /// <param name="backStr">备用异常消息：当ex为null时有效</param>  
        /// <returns>异常字符串文本</returns>  
        public static string GetExceptionMsg(Exception ex, string backStr) {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("****************************程序异常****************************");
            sb.AppendLine("【出现时间】：" + DateTime.Now);
            if(ex != null) {
                sb.AppendLine("【异常类型】：" + ex.GetType().Name);
                sb.AppendLine("【异常信息】：" + ex.Message);
                sb.AppendLine("【堆栈调用】：" + ex.StackTrace);
            } else {
                sb.AppendLine("【未处理异常】：" + backStr);
            }
            sb.AppendLine("***************************************************************");
            return sb.ToString();
        }

        /// <summary>  
        /// 生成自定义异常消息  
        /// </summary>  
        /// <param name="ex">异常对象</param>  
        /// <param name="communicationMsg">备用异常消息：当ex为null时有效</param>  
        /// <returns>异常字符串文本</returns>  
        public static string GetExceptionWithCommunication(Exception ex, string communicationMsg) {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("****************************程序异常****************************");
            sb.AppendLine("【出现时间】：" + DateTime.Now);
            if(ex != null) {
                sb.AppendLine("【异常类型】：" + ex.GetType().Name);
                sb.AppendLine("【异常信息】：" + ex.Message);
                sb.AppendLine("【堆栈调用】：" + ex.StackTrace);
                sb.AppendLine("【当前报文】：" + communicationMsg);
            }
            sb.AppendLine("***************************************************************");
            return sb.ToString();
        }
    }
}
