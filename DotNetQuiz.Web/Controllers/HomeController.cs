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

            var question = context.Questions.FirstOrDefault();
            var answers = context.Answers.ToList();

            var viewModel = new QuizViewModel
            {
                Questions = question,
                Answers = answers
            };

            return View(viewModel);
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