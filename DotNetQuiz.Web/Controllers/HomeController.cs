using DotNetQuiz.Web.Models;
using System.Linq;
using System.Web.Mvc;
using ServiceStack.OrmLite;
using ServiceStack.OrmLite.Sqlite;
using ServiceStack.Common.Utils;
using System.Collections.Generic;

namespace DotNetQuiz.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // TODO: Move to a repository
            var sqlLiteFile = "~/App_Data/sqLiteDb".MapHostAbsolutePath();
            var dbFactory = new OrmLiteConnectionFactory(sqlLiteFile, autoDisposeConnection: false, dialectProvider: SqliteDialect.Provider);

            using (var db = dbFactory.Open())
            {
                var question = db.Select<Questions>();

                return View(question);
            }
        }
    }
}