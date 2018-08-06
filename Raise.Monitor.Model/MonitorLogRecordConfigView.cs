﻿using System;

namespace Raise.Monitor.Model {
    public class MonitorLogRecordConfigView {
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
        }/// <summary>
         /// CRON表达式
         /// </summary>
        public string Cron {
            get; set;
        }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description {
            get; set;
        }

        /// <summary>
        /// 触发器名称
        /// </summary>
        public string TriggerName {
            get; set;
        }

        /// <summary>
        /// 作业名称
        /// </summary>
        public string JobName {
            get; set;
        }

        /// <summary>
        /// 请求类型
        /// </summary>
        public string Method {
            get; set;
        }

        /// <summary>
        /// POST参数
        /// </summary>
        public string PostBody {
            get; set;
        }

        /// <summary>
        /// 方法名称，务必填写，用以检查是否有重复的调度
        /// </summary>
        public string ServiceName {
            get; set;
        }

        /// <summary>
        /// 创建人
        /// </summary>
        public string Author {
            get; set;
        }

        /// <summary>
        /// Content-Type
        /// </summary>
        public string ContentType {
            get; set;
        }

        /// <summary>
        /// 是否oData认证
        /// </summary>
        public int IsAuthentication {
            get; set;
        }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName {
            get; set;
        }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password {
            get; set;
        }

        /// <summary>
        /// 服务地址
        /// </summary>
        public string Address {
            get; set;
        }

        /// <summary>
        /// JOB分组
        /// </summary>
        public string GroupName {
            get; set;
        }

        /// <summary>
        /// 状态
        /// </summary>
        public int Status {
            get; set;
        }

        /// <summary>
        /// 是否调用WebService
        /// </summary>
        public int IsWebService {
            get;
            set;
        }

        /// <summary>
        /// 唯一标识
        /// </summary>
        public string UniqueCode {
            get; set;
        }

        /// <summary>
        /// 日志创建时间
        /// </summary>
        public DateTime CreateTime {
            get;
            set;
        }

        /// <summary>
        /// 状态码
        /// </summary>
        public int StatusCode {
            get;
            set;
        }

        /// <summary>
        /// 状态码描述
        /// </summary>
        public string StatusCodeDescription {
            get;
            set;
        }

        /// <summary>
        /// 响应报文
        /// </summary>
        public string ResponseMessage {
            get; set;
        }
    }
}
