namespace DotNetQuiz.Data
{
    using ServiceStack.Common.Utils;
    using ServiceStack.OrmLite;
    using ServiceStack.OrmLite.Sqlite;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Linq;

    public class DbContext : IDbContext
    {
        private readonly IDbConnectionFactory connection;

        public DbContext()
        {
            connection = new OrmLiteConnectionFactory(ConfigurationManager.AppSettings["SqliteFile"].MapHostAbsolutePath(), false, SqliteDialect.Provider);
        }

        public DbContext(IDbConnectionFactory connection)
        {
            this.connection = connection;
        }

        public IEnumerable<T> SelectAll<T>()
        {
            using (var db = connection.Open())
            {
                return db.Select<T>();
            }
        }

        public void Insert<T>(T entity) where T : class, new()
        {
            using (IDbConnection db = connection.OpenDbConnection())
            {
                db.Insert(entity);
            }
        }
    }
}