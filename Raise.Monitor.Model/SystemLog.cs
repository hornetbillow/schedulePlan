using System;

namespace Raise.Monitor.Model {
    public class SystemLog {
        public int Id {
            get; set;
        }
        /// <summary>
        /// 消息
        /// </summary>
        public string Message {
            get; set;
        }
        /// <summary>
        /// 报文产生位置
        /// </summary>
        public string Callsite {
            get; set;
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime {
            get; set;
        }
        /// <summary>
        /// 日志级别
        /// </summary>
        public string LogLevel {
            get; set;
        }
        /// <summary>
        /// 堆栈信息
        /// </summary>
        public string StackTrace {
            get; set;
        }
    }
}
