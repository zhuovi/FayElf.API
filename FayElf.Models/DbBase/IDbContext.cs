namespace FayElf.Models.DbBase
{
    public interface IDbContext
    {
        /// <summary>
        /// 数据库操作对象
        /// </summary>
        public DataHelper DataHelper { get; set; }
        /// <summary>
        /// IQueryableX对象
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <returns></returns>
        public IQueryableX<T> Queryable<T>();
        /// <summary>
        /// IQueryableX对象
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <returns></returns>
        public IQueryableX<T> Query<T>();
    }

}
