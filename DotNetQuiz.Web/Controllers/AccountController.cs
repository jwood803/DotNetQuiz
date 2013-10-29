using DotNetQuiz.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace DotNetQuiz.Web.Models
{
    public class AccountController : Controller
    {
        private readonly IDbContext db;

        public AccountController()
        {
        }

        public AccountController(IDbContext db)
        {
            this.db = db;
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (FormsAuthentication.Authenticate(model.Username, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.Username, true);
                    return Redirect(returnUrl ?? Url.Action("Index", "Home"));
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Username and password are incorrect");
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel model)
        {
            return View();
        }

        [Authorize]
        public ActionResult Create()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }

            ModelState.AddModelError(string.Empty, "You are not authorized to go to this page.");

            return Redirect(Url.Action("Index", "Home"));
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Questions question)
        {
            if (!ModelState.IsValid)
            {
                return View(question);
            }

            db.Insert<Questions>(question);

            return RedirectToAction("Index", "Home");
        }
    }
}