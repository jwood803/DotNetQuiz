﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetQuiz.Web.Models
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
    }
}