using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using DotNetQuiz.Web.Models;

namespace DotNetQuiz.Web
{
    public class QuizDatabaseInitializer : CreateDatabaseIfNotExists<QuizDataContext>
    {
        protected override void Seed(QuizDataContext context)
        {

            //base.Seed(context);
        }
    }
}