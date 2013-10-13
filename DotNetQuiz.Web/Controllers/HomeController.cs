using DotNetQuiz.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetQuiz.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var context = new QuizDataContext();

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

            // TODO: Perhaps a view model for this
            var question = context.Questions.FirstOrDefault();
            // var answers = context.Answers.ToList();
            
            return View(question);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}