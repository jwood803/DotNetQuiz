using ServiceStack.OrmLite;
using System.Configuration;
namespace DotNetQuiz.Data
{
    public class DbContext
    {
        private readonly IDbConnectionFactory connection;

        public DbContext()
        {
            connection = new OrmLiteConnectionFactory(ConfigurationManager.AppSettings["SqliteFile"], false, SqliteDialect.Provider);
        }

        public DbContext(IDbConnectionFactory connection)
        {
            this.connection = connection;
        }
    }
}