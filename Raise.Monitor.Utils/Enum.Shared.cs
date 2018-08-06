namespace Raise.Monitor.Tools {
    /// <summary>
    /// 接收到的报文PMS是否处理成功  失败是-1，成功=0
    /// </summary>
    public enum OperationType {
        接收成功 = 0,
        处理成功 = 1,
        处理失败 = 99,
        未知数据 = 100
    }

    /// <summary>
    /// 是否
    /// </summary>
    public enum YesOrNo {
        是 = 1,
        否 = 0
    }

    /// <summary>
    /// 基础数据状态
    /// </summary>
    public enum BasicStatus {
        有效 = 1,
        作废 = 99
    }

    /// <summary>
    /// 运行状态
    /// </summary>
    public enum RunStatus {
        停用 = 1,
        启用 = 2
    }

    /// <summary>
    /// 错误类型
    /// </summary>
    public enum ErrorType {
        业务错误 = 1,
        系统错误 = 2,
        其他错误 = 3
    }

    /// <summary>
    /// 消息状态
    /// </summary>
    public enum MessageStatus {
        发生异常 = 1,
        调用成功 = 2
    }

    public enum LogLevel {
        Trace,
        Debug,
        Info,
        Warn,
        Error,
        Fatal,
        Off
    }
}
