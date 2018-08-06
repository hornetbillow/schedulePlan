using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Dapper;
using Newtonsoft.Json;
using NLog;
using Oracle.ManagedDataAccess.Client;

namespace Raise.Monitor.Tools {
    public static class DapperDbContext {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger(typeof(DapperDbContext));

        public static IDbConnection GetConnection {
            get {
                string connString = Utils.ConnectString;
                return new OracleConnection(connString);
            }
        }

        public static List<T> AsList<T>(this IEnumerable<T> source) {
            if(source != null && !(source is List<T>))
                return source.ToList();
            return (List<T>)source;
        }

        public static int Execute(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null, int databaseOption = 1) {
            using(var conn = GetConnection) {
                var info = "SQL语句:" + sql + "  \n SQL参数: " + JsonConvert.SerializeObject(param) + " \n";
                var sw = new Stopwatch();
                sw.Start();
                var restult = conn.Execute(sql, param, transaction, commandTimeout, commandType);
                sw.Stop();
                Logger.Info(info + "耗时:" + sw.ElapsedMilliseconds + (sw.ElapsedMilliseconds > 1000 ? "#####" : string.Empty) + "\n");
                return restult;
            }
        }

        public static PageData<T> ExecuteWithPageing<T>(string sql, int pageIndex, bool isAppendWhere = false, string sortColumn = "", bool sortAsc = true) where T : class {
            var conn = GetConnection;
            var sqlBuilder = new StringBuilder();
            if(isAppendWhere)
                sqlBuilder.AppendLine($"{sql} where 1=1 ");
            else sqlBuilder.Append($"{sql} ");
            sql = $"select count(*) from ({sql})";
            var page = new PageData<T>();
            var log = new StringBuilder();
            if(!Utils.IsProduction) {
                log.AppendLine($"***************{DateTime.Now:执行时间：yyyy-MM-dd HH:mm:ss}*********************");
                log.AppendLine($"执行总数统计SQL:\n{sql}");
            }
            sqlBuilder.AppendFormat("AND ROWNUM <= {0}*{1}", pageIndex, GlobalVar.PAGE_SIZE);
            if(!string.IsNullOrEmpty(sortColumn))
                sqlBuilder.AppendFormat($"order by {sortColumn}" + (sortAsc ? " ASC " : " DESC "));

            var executeSql = $"SELECT * FROM ({sqlBuilder}) TABLE_ALIAS WHERE TABLE_ALIAS.ROWNO  > {GlobalVar.PAGE_SIZE}*({pageIndex}-1)";

            if(!Utils.IsProduction) {
                log.AppendLine("-----------------------");
                log.AppendLine($"执行分页数据查询SQL:\n{executeSql}");
                log.AppendLine($"***************{DateTime.Now:执行结束：yyyy-MM-dd HH:mm:ss}*********************");
                Logger.Info(log.ToString());
            }
            page.Total = Convert.ToInt32(conn.ExecuteScalar(sql));
            page.Data = conn.Query<T>(executeSql).ToList();
            return page;
        }

        public static int Execute(CommandDefinition command, int databaseOption = 1) {
            using(var conn = GetConnection) {
                var info = " SQL语句:" + command.CommandText + "  \n SQL命令类型: " + command.CommandType + " \n";
                var sw = new Stopwatch(); sw.Start();
                var restult = conn.Execute(command);
                sw.Stop();
                Logger.Info(info + "耗时:" + sw.ElapsedMilliseconds + (sw.ElapsedMilliseconds > 1000 ? "#####" : string.Empty) + "\n");
                return restult;
            }
        }
    }
}
