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
            context.Questions.Add(new Questions
            {
                QuestionText = "What does CLR stand for?",
                CorrectAnswerId = 3,
                Answers = new List<Answers>
                    {
                        new Answers { AnswerText = "Clear Light Reflection" },
                        new Answers { AnswerText = "Calcium Lime Random" },
                        new Answers { AnswerText = "Common Language Runtime" },
                        new Answers { AnswerText = "Clears Lime Ridiculously" }
                    }
            });

            context.SaveChanges();

            base.Seed(context);
        }
    }
}