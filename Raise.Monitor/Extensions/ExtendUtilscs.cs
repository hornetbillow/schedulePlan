using System.Windows.Forms;

namespace Raise.Monitor.Extensions {
    public static class ExtendUtilscs {
        /// <summary>
        /// DataGridView清空数据源
        /// </summary>
        /// <param name="dataGridView">DataGridView对象</param>
        public static void ClearDataSource(this DataGridView dataGridView) {
            dataGridView.DataSource = null;
        }
    }
}
