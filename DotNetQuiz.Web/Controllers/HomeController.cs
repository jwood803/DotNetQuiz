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
            // TODO: Move below to a repository
            //var sqlLiteFile = "~/App_Data/sqLiteDb".MapHostAbsolutePath();
            //Questions question;
            //var dbFactory = new OrmLiteConnectionFactory(sqlLiteFile, false, SqliteDialect.Provider);
            
            //using (var db = dbFactory.Open())
            //{
            //    db.CreateTableIfNotExists<Questions>();
            //    db.CreateTableIfNotExists<Answers>();

            //    db.Insert<Questions>(new Questions
            //    {
            //        QuestionText = "What does CLR stand for?",
            //        CorrectAnswerId = 3,
            //        Answers = new List<Answers>
            //            {
            //               new Answers { AnswerText = "Clear Light Reflection", QuestionsId = 1 },
            //               new Answers { AnswerText = "Calcium Lime Random", QuestionsId = 1 },
            //               new Answers { AnswerText = "Common Language Runtime", QuestionsId = 1 },
            //               new Answers { AnswerText = "Clears Lime Ridiculously", QuestionsId = 1 }
            //            }
            //    });

            //    question = db.Where<Questions>(x => x.QuestionId == 1)[0];
            //}

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