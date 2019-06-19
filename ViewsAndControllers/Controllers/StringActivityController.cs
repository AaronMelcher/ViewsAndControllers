﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsAndControllers.Controllers
{
    public class StringActivityController : Controller
    {
        // GET: StringActivity
        public ActionResult Index()
        {
            return View(viewName: "Index", model: "All starts here.");
        }

        [HttpPost]
        public ActionResult SayHello(string inputString)
        {
            return View(viewName: "Index", model: "Length of string: " + inputString.Length);
        }
    }
}