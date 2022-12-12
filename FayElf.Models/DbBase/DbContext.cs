using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FayElf.Models.DbBase
{
    public class DbContext : IDbContext
    {
        /// <summary>
        /// 数据库配置
        /// </summary>
        public ConnectionConfig ConnectionConfig { get; set; }
        /// <summary>
        /// 数据库操作对象
        /// </summary>
        public DataHelper DataHelper { get; set; }
        /// <summary>
        /// IQueryableX对象
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <returns></returns>
        public IQueryableX<T> Queryable<T>()
        {
            return new DataHelperX<T>(ConnectionConfig);
        }
        /// <summary>
        /// IQueryableX对象
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <returns></returns>
        public IQueryableX<T> Query<T>() => Queryable<T>();
        /// <summary>
        /// 构造器
        /// </summary>
        public DbContext()
        {
            ConnectionConfig = new ConnectionConfig("FayElf");
            DataHelper = new DataHelper(ConnectionConfig);
        }

    }

}
