using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Transactions;
using Dapper;
using NLog;
using Oracle.ManagedDataAccess.Client;
using Raise.Monitor.Model;
using Raise.Monitor.Tools;

namespace Raise.Monitor.Service {
    public class ServiceUtils {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger(typeof(ServiceUtils));

        private static OracleConnection _connection;
        private static List<KeyValueItem> KeyValueItems = new List<KeyValueItem>();

        /// <summary>
        /// 获取数据库连接
        /// </summary>
        public static OracleConnection GetConnection {
            get {
                if(_connection == null) {
                    string connString = Utils.ConnectString;
                    _connection = new OracleConnection(connString);
                }
                return _connection;
            }
        }

        /// <summary>
        /// 获取所有的CRON表达式
        /// </summary>
        /// <returns></returns>
        public static List<CronExpression> GetCronExpressions() {
            using(var con = GetConnection) {
                con.Open();
                var result = con.Query<CronExpression>("SELECT * FROM CRONEXPRESSION").ToList();
                return result;
            }
        }

        /// <summary>
        /// 查询字典项
        /// </summary>
        /// <param name="name">字典项名称</param>
        /// <returns>KeyValueItem集合</returns>
        public static List<KeyValueItem> GetKeyValueItems(string name) {
            try {
                if(!KeyValueItems.Any()) {
                    var result = DapperDbContext.GetConnection.Query<KeyValueItem>("Select * from KeyValueItem k where k.Status = 2");
                    KeyValueItems.AddRange(result);
                }
            } catch(Exception e) {
                Logger.Error(e);
            }

            var keyValueItems = KeyValueItems.Where(data => data.Name == name).ToList();
            keyValueItems.Add(new KeyValueItem {
                Key = -1,
                Value = "不限"
            });
            return keyValueItems.OrderBy(data => data.Key).ToList();
        }

        public static PageData<MonitorLogRecordConfigView> GetConfigRulesWithLogs(int pageIndex, string keyWords, string method, string serviceName, int? status, DateTime beginTime, DateTime endTime) {
            var sqlBuilder = new StringBuilder();
            sqlBuilder.AppendLine("select m.responseMessage,m.ruleconfigid,m.operationtype,m.message,m.createtime,m.executetime,m.statusCode,m.statusCodeDescription,r.*,rownum as rowno from monitorlogrecord m inner join ruleconfig r on m.ruleconfigid = r.id where 1=1 ");
            if(!string.IsNullOrEmpty(keyWords)) {
                sqlBuilder.AppendFormat("and (Upper(r.Description) like Upper('%{0}%') or Upper(r.Method) like Upper('%{0}%') or Upper(r.PostBody) like Upper('%{0}%') or Upper(r.ContentType) like Upper('%{0}%') or Upper(userName) like Upper('%{0}%')) ", keyWords.ToUpper()).AppendLine();
            }
            if(!string.IsNullOrEmpty(method)) {
                sqlBuilder.AppendFormat("and upper(r.Method) like Upper('%{0}%') ", method.ToUpper()).AppendLine();
            }
            if(status.HasValue && status > 0) {
                sqlBuilder.AppendFormat("and r.Status = {0} ", status.Value).AppendLine();
            }
            if(!string.IsNullOrEmpty(serviceName)) {
                sqlBuilder.AppendFormat("and upper(r.ServiceName) like Upper('%{0}') ", serviceName.ToUpper()).AppendLine();
            }

            sqlBuilder.AppendFormat("and m.CreateTime >= to_date('{0:yyyy-MM-dd}','yyyy-mm-dd') ", beginTime).AppendLine();
            sqlBuilder.AppendFormat("and m.CreateTime <= to_date('{0:yyyy-MM-dd}','yyyy-mm-dd') ", endTime.AddDays(1)).AppendLine();

            return DapperDbContext.ExecuteWithPageing<MonitorLogRecordConfigView>(sqlBuilder.ToString(), pageIndex);
        }

        public static PageData<SystemLog> GetSystemLogs(int pageIndex, string keyWords, string callsite, string logLevel, DateTime beginTime, DateTime endTime) {
            var sqlBuilder = new StringBuilder();
            sqlBuilder.AppendLine("select r.*,rownum as rowno from SysLog r where 1=1 ");
            if(!string.IsNullOrEmpty(keyWords)) {
                sqlBuilder.AppendFormat("and (Upper(r.Message) like Upper('%{0}%') or Upper(r.callsite) like Upper('%{0}%')) ", keyWords.ToUpper()).AppendLine();
            }
            if(!string.IsNullOrEmpty(callsite)) {
                sqlBuilder.AppendFormat("and upper(r.callsite) like Upper('%{0}') ", callsite).AppendLine();
            }
            if(!string.IsNullOrEmpty(logLevel)) {
                sqlBuilder.AppendFormat("and r.LogLevel = '{0}' ", logLevel).AppendLine();
            }

            sqlBuilder.AppendFormat("and r.CreateTime >= to_date('{0:yyyy-MM-dd}','yyyy-mm-dd') ", beginTime).AppendLine();
            sqlBuilder.AppendFormat("and r.CreateTime <= to_date('{0:yyyy-MM-dd}','yyyy-mm-dd') ", endTime.AddDays(1)).AppendLine();

            return DapperDbContext.ExecuteWithPageing<SystemLog>(sqlBuilder.ToString(), pageIndex);
        }

        public static PageData<RuleConfig> GetConfigRules(int pageIndex, string keyWords, string requestType, string serviceName, int? runStatus, int? status) {
            var conn = DapperDbContext.GetConnection;
            var sqlBuilder = new StringBuilder();
            sqlBuilder.AppendLine("select r.*,rownum as rowno from ruleconfig r where 1=1 ");
            if(!string.IsNullOrEmpty(keyWords)) {
                sqlBuilder.AppendFormat("and (Upper(r.Description) like Upper('%{0}%') or Upper(r.Method) like Upper('%{0}%') or Upper(r.PostBody) like Upper('%{0}%') or Upper(r.ContentType) like Upper('%{0}%') or Upper(userName) like Upper('%{0}%')) ", keyWords.ToUpper()).AppendLine();
            }
            if(!string.IsNullOrEmpty(requestType)) {
                sqlBuilder.AppendFormat("and upper(r.method) like Upper('%{0}%') ", requestType.ToUpper()).AppendLine();
            }
            if(runStatus.HasValue && runStatus > 0) {
                sqlBuilder.AppendFormat("and r.RunStatus = {0} ", runStatus.Value).AppendLine();
            }
            if(status.HasValue && status > 0) {
                sqlBuilder.AppendFormat("and r.status = {0} ", status.Value).AppendLine();
            }
            if(!string.IsNullOrEmpty(serviceName)) {
                sqlBuilder.AppendFormat("and Upper(r.ServiceName) like Upper('%{0}') ", serviceName.ToUpper()).AppendLine();
            }

            return DapperDbContext.ExecuteWithPageing<RuleConfig>(sqlBuilder.ToString(), pageIndex);
        }

        public static void SetRuleConfigStatus(int id, int status) {
            DapperDbContext.Execute("Update RuleConfig set Status = :status where Id = :id", new { status, id });
        }

        public static void SetRuleConfigRunStatus(int id, int runStatus) {
            DapperDbContext.Execute("Update RuleConfig set RunStatus = :runStatus where Id = :id", new { runStatus, id });
        }

        public static MessageInformation InsertRule(RuleConfig config) {
            var messageInformation = new MessageInformation();
            try {
                config.UniqueCode = Utils.Guid;
                bool isValid =
                    DapperDbContext.GetConnection.QueryFirstOrDefault<RuleConfig>(
                        "Select * from RuleConfig r where r.jobName = :JobName or triggername = :TriggerName or servicename= :ServiceName",
                        config) == null;
                if(!isValid) {
                    throw new ValidationException("JobName,TriggerName,MethodName必须唯一");
                }
                string sql = @"insert into RuleConfig
                              (id,
                               cron,
                               description,
                               triggername,
                               jobname,
                               method,
                               postbody,
                               servicename,
                               author,
                               contenttype,
                               isauthentication,
                               username,
                               password,
                               groupname,
                               address,
                               status,
                               isWebService,
                               uniqueCode,
                               runStatus)
                            values
                              (s_RuleConfig.Nextval,
                               :Cron,
                               :Description,
                               :TriggerName,
                               :JobName,
                               :Method,
                               :PostBody,
                               :ServiceName,
                               :Author,
                               :ContentType,
                               :IsAuthentication,
                               :UserName,
                               :Password,
                               :GroupName,
                               :Address,
                               :Status,
                               :IsWebService,
                               :UniqueCode,
                               :RunStatus)";
                DapperDbContext.Execute(sql, config);
                messageInformation.ExecuteSuccess("数据插入成功");
            } catch(Exception e) {
                messageInformation.ExecuteError(e);
            }
            return messageInformation;
        }

        //DEMO
        public void Insert() {
            using(TransactionScope scope = new TransactionScope()) {
                using(var con = GetConnection) {
                    scope.Complete();
                }
            }
        }
    }
}
