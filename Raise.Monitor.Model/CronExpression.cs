namespace Raise.Monitor.Model {
    public class CronExpression {
        public int Id {
            get; set;
        }
        /// <summary>
        /// 时间表达式
        /// </summary>
        public string Cron {
            get; set;
        }
        /// <summary>
        /// 表达式含义
        /// </summary>
        public string CronDescription {
            get; set;
        }
    }
}
