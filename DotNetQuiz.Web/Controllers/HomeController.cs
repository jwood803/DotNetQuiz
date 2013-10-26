using DotNetQuiz.Web.Models;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;
using DotNetQuiz.Data;

namespace DotNetQuiz.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDbContext db;

        public HomeController() : this (new DbContext())
        {
        }

        public HomeController(IDbContext db)
        {
            this.db = db;
        }

        public ActionResult Index()
        {
            var questions = db.SelectAll<Questions>();

            return View(questions);
        }
    }
}