namespace DotNetQuiz.Data
{
    using ServiceStack.Common.Utils;
    using ServiceStack.OrmLite;
    using System.Collections.Generic;
    using System.Configuration;
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
    }
}