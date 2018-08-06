namespace Raise.Monitor.Model {
    public class KeyValueItem {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id {
            get; set;
        }
        /// <summary>
        /// 字典英文名称
        /// </summary>
        public string Name {
            get; set;
        }
        /// <summary>
        /// 字典名称
        /// </summary>
        public string Caption {
            get; set;
        }
        /// <summary>
        /// 字典键
        /// </summary>
        public int Key {
            get; set;
        }
        /// <summary>
        /// 字典值
        /// </summary>
        public string Value {
            get; set;
        }
        /// <summary>
        /// 状态
        /// </summary>
        public int Status {
            get; set;
        }
    }
}
