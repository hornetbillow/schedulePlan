using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Raise.Monitor;
using Raise.Monitor.Extensions;
using Sunlight.Dispatch.UI.Extensions;

namespace Sunlight.Dispatch.UI {
    /// <summary>
    /// 用于新增或者编辑界面
    /// </summary>
    public class BaseEditFrm : BaseFrm, INotifyPropertyChanged {
        private object dataContext;
        protected string ConnectString {
            get;
            set;
        }

        /// <summary>
        /// 当前新增或者更新的上下文
        /// </summary>
        public object DataContext {
            get {
                return this.dataContext;
            }
            set {
                this.dataContext = value;
                this.OnPropertyChanged();
            }
        }

        /// <summary>
        /// 新增时执行
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        public TEntity CreateObjectToEdit<TEntity>(string connectString) where TEntity : class, new() {
            var entity = Activator.CreateInstance<TEntity>();
            this.DataContext = entity;
            EditState = EditState.新增;
            this.ConnectString = connectString;
            return entity;
        }

        /// <summary>
        /// 传入Id
        /// </summary>
        /// <param name="identity">主键</param>
        /// <param name="connectString">当前数据库连接</param>
        public virtual void SetObjectToEditById(object identity, string connectString) {
            this.ConnectString = connectString;
        }

        /// <summary>
        /// 编辑时使用
        /// </summary>
        /// <param name="entity"></param>
        protected void SetObjectToEdit(object entity) {
            EditState = EditState.编辑;
            this.DataContext = entity;
        }

        public new event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
