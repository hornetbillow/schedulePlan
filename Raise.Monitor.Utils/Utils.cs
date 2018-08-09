using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.ServiceProcess;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using Oracle.ManagedDataAccess.Client;
using Quartz;
using Quartz.Spi;

namespace Raise.Monitor.Tools {
    public static class Utils {
        /// <summary>
        /// 获取数据库连接字符串
        /// </summary>
        /// <returns>队列名称</returns>
        public static string ConnectString {
            get {
                var reader = new AppSettingsReader();
                var queueName = reader.GetValue("ConnectionString", typeof(string));

                if(queueName == null)
                    throw new KeyNotFoundException("配置文件中，ConnectionString配置节未找到，请重新配置");

                return queueName.ToString();
        }

        /// <summary>
        /// 获取任务在未来周期内哪些时间会运行
        /// </summary>
        /// <param name="cronExpression">Cron表达式</param>
        /// <param name="numTimes">运行次数</param>
        /// <returns>运行时间段</returns>
        public static List<string> GetTaskeFireTime(string cronExpression, int numTimes = 50) {
            if(numTimes < 0) {
                throw new Exception("参数numTimes值大于等于0");
            }
            //时间表达式
            ITrigger trigger = TriggerBuilder.Create().WithCronSchedule(cronExpression).Build();
            var dates = TriggerUtils.ComputeFireTimes(trigger as IOperableTrigger, null, numTimes);
            List<string> list = new List<string>();
            foreach(DateTimeOffset dtf in dates) {
                list.Add(TimeZoneInfo.ConvertTimeFromUtc(dtf.DateTime, TimeZoneInfo.Local).ToString(CultureInfo.InvariantCulture));
            }
            return list;
        }

        /// <summary>
        /// 判断输入的字符串是否是int类型
        /// </summary>
        /// <param name="value"></param>
        /// <returns>返回判断结果</returns>
        public static bool IsInt(string value) {
            return Regex.IsMatch(value, @"^[+-]?\d*$");
        }

        /// <summary>
        /// 读取配置节
        /// </summary>
        /// <returns>配置Key</returns>
        public static string GetAppStringByKey(string key, Type type) {
            var reader = new AppSettingsReader();
            var queueName = reader.GetValue($"{key}", type);

            if(queueName == null)
                throw new KeyNotFoundException($"配置文件中，{key}配置节未找到，请重新配置");

            return queueName.ToString();
        }

        /// <summary>
        /// 获取是否生产环境
        /// </summary>
        /// <returns>是否</returns>
        public static bool IsProduction {
            get {
                var isProduct = GetAppStringByKey("IsProduction", typeof(bool)).ToUpper();
                return isProduct == "TRUE";
            }
        }

        /// <summary>
        /// 测试数据库是否可以正常连接
        /// </summary>
        /// <param name="msg">连接结果</param>
        /// <param name="connectionString">连接字符串</param>
        /// <returns>是否连接成功</returns>
        public static bool IsCanConnect(out string msg, string connectionString) {
            if(string.IsNullOrEmpty(connectionString))
                throw new Exception("IsCanConnect Parameter is not null");
            msg = string.Empty;
            try {
                using(var conn = new OracleConnection(ConnectString)) {
                    conn.Open();
                }

                return true;
            } catch(Exception ex) {
                var stringBuilder = new StringBuilder();
                stringBuilder.AppendLine(connectionString);
                stringBuilder.AppendLine(ex.Message);
                msg = stringBuilder.ToString();
                return false;
            }
        }

        /// <summary>
        /// 格式化XML文件
        /// </summary>
        /// <param name="xml">XML报文</param>
        /// <returns>格式化的报文</returns>
        public static string FormatXml(object xml) {
            if(xml == null)
                return string.Empty;
            XmlDocument xd;
            if(xml is XmlDocument) {
                xd = xml as XmlDocument;
            } else {
                xd = new XmlDocument();
                xd.LoadXml(xml.ToString());
            }
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            XmlTextWriter xtw = null;
            try {
                xtw = new XmlTextWriter(sw);
                xtw.Formatting = Formatting.Indented;
                xtw.Indentation = 1;
                xtw.IndentChar = '\t';
                xd.WriteTo(xtw);
            } finally {
                if(xtw != null)
                    xtw.Close();
            }
            return sb.ToString();
        }

        /// <summary>
        /// 单实例程序控制，每次只能启动一个程序
        /// </summary>
        /// <returns>是否可以打开</returns>
        public static bool HasRunning() {
            Process currentProcess = Process.GetCurrentProcess();
            Process[] processCollection = Process.GetProcessesByName(currentProcess.ProcessName);
            foreach(Process p in processCollection) {
                if(p.Id == currentProcess.Id) {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 获取本机的IP地址
        /// </summary>
        /// <returns>返回本机的IP 地址</returns>
        public static List<IPAddress> GetHostIpList() {
            string name = Dns.GetHostName();
            IPAddress[] ipadrlist = Dns.GetHostAddresses(name);

            var interNetwork = new List<IPAddress>();
            foreach(IPAddress ipa in ipadrlist) {
                if(ipa.AddressFamily == AddressFamily.InterNetwork)
                    interNetwork.Add(ipa);
            }

            return interNetwork;
        }

        /// <summary>
        /// 获取事务Id
        /// </summary>
        /// <param name="xml">报文</param>
        /// <returns>事务Id</returns>
        public static string GetBizTransactionId(string xml) {
            string bizTransactionIdElement = string.Empty;
            try {
                MatchCollection collection = Regex.Matches(xml, @"<BIZTRANSACTIONID.*>?.*<?\/BIZTRANSACTIONID>");
                if(collection.Count > 1)
                    throw new Exception("报文解析BIZTRANSACTIONID出错");

                bizTransactionIdElement = collection[0].Value;
                if(string.IsNullOrEmpty(bizTransactionIdElement))
                    throw new Exception("报文解析BIZTRANSACTIONID出错");
                var bizTransactionId = bizTransactionIdElement.Replace("<BIZTRANSACTIONID>", "").Replace("</BIZTRANSACTIONID>", "");
                bizTransactionId = bizTransactionId.Replace("<BIZTRANSACTIONID type=\"string\">", "");

                return bizTransactionId;
            } catch(Exception ex) {
                LoggerUtils.Error(ex.Message);
                //解析出错后，将整个BIZTRANSACTIONID标签进行存储
                return bizTransactionIdElement;
            }
        }

        /// <summary>
        /// 验证CRON表达式是否合法
        /// </summary>
        /// <param name="cron">CRON表达式</param>
        /// <returns>验证结果</returns>
        public static bool IsValidExpression(string cron) {
            if(CronExpression.IsValidExpression(cron))
                return true;
            return false;
        }

        /// <summary>
        /// 唯一标识
        /// </summary>
        public static string Guid {
            get {
                return System.Guid.NewGuid().ToString().Replace("-", "").ToUpper();
            }
        }

        /// <summary>
        /// 开启Windows服务
        /// </summary>
        /// <param name="windowsServiceName">服务名称</param>
        public static MessageInformation StartWindowsService(string windowsServiceName) {
            var messageInformation = new MessageInformation();

            try {
                var isNotExists = ServiceController.GetServices().All(data => data.ServiceName != windowsServiceName);
                if(isNotExists)
                    throw new Exception($"Windows服务{windowsServiceName}不存在");
                using(ServiceController control = new ServiceController(windowsServiceName)) {
                    if(control.Status == ServiceControllerStatus.Stopped) {
                        control.Start();
                        control.WaitForStatus(ServiceControllerStatus.Running);
                        messageInformation.ExecuteSuccess($"{windowsServiceName}调度服务已重新启动");
                    } else if(control.Status == ServiceControllerStatus.Running) {
                        if(!control.CanStop) {
                            messageInformation.ExecuteError($"{windowsServiceName}发生意外故障，请在服务列表中，重启调度服务以确保配置生效");
                        } else {
                            control.Stop();
                            control.Start();
                            messageInformation.ExecuteSuccess($"{windowsServiceName}调度服务已重新启动");
                        }
                    }
                }
            } catch(Exception e) {
                messageInformation.ExecuteError($"{windowsServiceName}启动时，发生如下异常：\r" + e.Message);
            }

            return messageInformation;
        }

        /// <summary>
        /// 停止Windows服务
        /// </summary>
        /// <param name="windowsServiceName">服务名称</param>
        public static MessageInformation StopWindowsService(string windowsServiceName) {
            var messageInformation = new MessageInformation();
            try {
                var isNotExists = ServiceController.GetServices().All(data => data.ServiceName != windowsServiceName);
                if(isNotExists)
                    throw new Exception($"Windows服务{windowsServiceName}不存在");
                using(ServiceController control = new ServiceController(windowsServiceName)) {
                    if(control.Status == ServiceControllerStatus.Running) {
                        control.Stop();
                        messageInformation.ExecuteSuccess($"{windowsServiceName}调度服务已正确关闭");
                    } else if(control.Status == ServiceControllerStatus.Stopped) {
                        messageInformation.ExecuteError($"{windowsServiceName}调度服务已经处于关闭当中");
                    }
                    control.WaitForStatus(ServiceControllerStatus.Stopped);
                }
            } catch(Exception e) {
                messageInformation.ExecuteError($"{windowsServiceName}停止时，发生如下异常：\r" + e.Message);
            }
            return messageInformation;
        }
    }
}
