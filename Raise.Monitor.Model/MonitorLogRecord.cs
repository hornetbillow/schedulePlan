namespace Raise.Monitor.Model {
    /// <summary>
    /// 监听日志记录
    /// </summary>
    public class MonitorLogRecord {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id {
            get;
            set;
        }
        /// <summary>
        /// 规则Id
        /// </summary>
        public string RuleConfigId {
            get;
            set;
        }
        /// <summary>
        /// 1为成功，99为失败
        /// </summary>
        public int OperationType {
            get;
            set;
        }
        /// <summary>
        /// 1为成功，99为失败
        /// </summary>
        public string OperationTypeName {
            get;
            set;
        }
        /// <summary>
        /// 错误消息
        /// </summary>
        public string Message {
            get; set;
        }
        /// <summary>
        /// 是否被选择 冗余字段
        /// </summary>
        public bool IsSelected {
            get; set;
        }
    }
}
