using System.Collections.Generic;
using Newtonsoft.Json;
using Raise.Monitor.Model;
using Raise.Monitor.Properties;

namespace Raise.Monitor {
    /// <summary>
    /// 获取配置文件中的复杂配置
    /// </summary>
    public class SettingUtils {
        /// <summary>
        /// 获取本应用管理的Windows服务
        /// </summary>
        public static List<ServiceExtension> ServiceNames {
            get {
                var serviceList = Settings.Default.ServiceNames;
                if(string.IsNullOrEmpty(serviceList))
                    return null;
                return JsonConvert.DeserializeObject<List<ServiceExtension>>(serviceList);
            }
        }
    }
}
