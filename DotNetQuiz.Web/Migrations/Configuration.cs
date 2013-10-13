namespace DotNetQuiz.Web.Migrations
{
    using DotNetQuiz.Web.Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DotNetQuiz.Web.QuizDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DotNetQuiz.Web.QuizDataContext context)
        {
            //  This method will be called after migrating to the latest version.

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
        }
    }
}
