using DotNetQuiz.Web.Models;
using System.Linq;
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
    }
}