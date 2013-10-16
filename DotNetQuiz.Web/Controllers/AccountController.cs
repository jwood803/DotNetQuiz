﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace DotNetQuiz.Web.Models
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (FormsAuthentication.Authenticate(model.Username, model.Password))
                {
                    return Redirect(returnUrl ?? Url.Action("Index", "Home"));
                }
                else
                {
                    ModelState.AddModelError("", "Username and password are incorrect");
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
    }
}