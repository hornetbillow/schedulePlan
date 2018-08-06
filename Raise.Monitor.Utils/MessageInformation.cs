using System;
using System.Collections.Generic;

namespace Raise.Monitor.Tools {
    public class MessageInformation<T> where T : class {
        /// <summary>
        /// 返回的数据
        /// </summary>
        public List<T> Data { get; } = new List<T>();

        /// <summary>
        /// 装载数据
        /// </summary>
        public void SetData(List<T> setData) {
            this.Data.Clear();
            this.Data.AddRange(setData);
        }

        /// <summary>
        /// 调用结果
        /// </summary>
        public string Message {
            get; private set;
        }
        /// <summary>
        /// 调用返回的状态
        /// </summary>
        public int Status {
            get; private set;
        }

        /// <summary>
        /// 状态码
        /// </summary>
        public int StatusCode {
            get; private set;
        }

        /// <summary>
        /// 状态码描述
        /// </summary>
        public string StatusCodeDescription {
            get; private set;
        }

        /// <summary>
        /// 服务器响应的报文信息
        /// </summary>
        public string ResponseMessage {
            get; private set;
        }

        /// <summary>
        /// 状态码相关
        /// </summary>
        /// <param name="statusCode">Http状态码</param>
        /// <param name="statusCodeDescription">状态码描述</param>
        public void ExecuteStatusCode(int statusCode, string statusCodeDescription) {
            this.StatusCode = statusCode;
            this.StatusCodeDescription = statusCodeDescription;
        }

        /// <summary>
        /// 填充报文信息
        /// </summary>
        /// <param name="response">报文信息</param>
        public void ExecuteResponseMessage(string response) {
            this.ResponseMessage = response;
        }

        /// <summary>
        /// 执行错误时调用
        /// </summary>
        /// <param name="message">消息</param>
        public void ExecuteError(string message) {
            this.Message = message;
            this.Status = (int)MessageStatus.发生异常;
        }

        /// <summary>
        /// 执行错误时调用
        /// </summary>
        /// <param name="exception">消息</param>
        public void ExecuteError(Exception exception) {
            this.Message = exception.Message;
            this.Status = (int)MessageStatus.发生异常;
        }

        /// <summary>
        /// 执行成功时调用
        /// </summary>
        /// <param name="message">消息</param>
        public void ExecuteSuccess(string message) {
            this.Message = message;
            this.Status = (int)MessageStatus.调用成功;
        }

        /// <summary>
        /// 默认初始化Status为成功
        /// </summary>
        public MessageInformation() {
            this.Status = (int)MessageStatus.调用成功;
        }
    }
    public class MessageInformation {
        /// <summary>
        /// 调用结果
        /// </summary>
        public string Message {
            get; private set;
        }
        /// <summary>
        /// 调用返回的状态
        /// </summary>
        public int Status {
            get; private set;
        }

        /// <summary>
        /// 执行错误时调用
        /// </summary>
        /// <param name="message">消息</param>
        public void ExecuteError(string message) {
            this.Message = message;
            this.Status = (int)MessageStatus.发生异常;
        }

        /// <summary>
        /// 状态码
        /// </summary>
        public int StatusCode {
            get; private set;
        }

        /// <summary>
        /// 状态码描述
        /// </summary>
        public string StatusCodeDescription {
            get; private set;
        }

        /// <summary>
        /// 服务器响应的报文信息
        /// </summary>
        public string ResponseMessage {
            get; private set;
        }

        /// <summary>
        /// 填充报文信息
        /// </summary>
        /// <param name="response">报文信息</param>
        public void ExecuteResponseMessage(string response) {
            this.ResponseMessage = response;
        }

        /// <summary>
        /// 状态码相关
        /// </summary>
        /// <param name="statusCode">Http状态码</param>
        /// <param name="statusCodeDescription">状态码描述</param>
        public void ExecuteStatusCode(int statusCode, string statusCodeDescription) {
            this.StatusCode = statusCode;
            this.StatusCodeDescription = statusCodeDescription;
        }

        /// <summary>
        /// 执行错误时调用
        /// </summary>
        /// <param name="exception">消息</param>
        public void ExecuteError(Exception exception) {
            this.Message = exception.Message;
            this.Status = (int)MessageStatus.发生异常;
        }

        /// <summary>
        /// 执行成功时调用
        /// </summary>
        /// <param name="message">消息</param>
        public void ExecuteSuccess(string message) {
            this.Message = message;
            this.Status = (int)MessageStatus.调用成功;
        }

        /// <summary>
        /// 默认初始化Status为成功
        /// </summary>
        public MessageInformation() {
            this.Status = (int)MessageStatus.调用成功;
        }
    }
}
