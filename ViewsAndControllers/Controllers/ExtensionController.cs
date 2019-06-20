using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsAndControllers.Controllers
{
    public class ExtensionController : Controller
    {
        // GET: Extension
        public ActionResult Index()
        {
            return View(viewName: "Index", model: "");
        }

        [HttpPost]
        public ActionResult NameLength(string inputString)
        {
            return View(viewName: "Index", model: "Length of string: " + inputString.Length);
        }

        public ActionResult FirstAndLast(string first, string last)
        {
            return View(viewName: "Index", model: "Your name is: " + first + " " + last);
        }

        public ActionResult DifferenceAgeAndLength(string last, int age)
        {
            return View(viewName: "Index", model: "The absolute value difference is: " + Math.Abs(last.Length - age));
        }

        public ActionResult YourAge(DateTime birthday)
        {
            return View(viewName: "Index", model: DateTime.Now.Year - birthday.Year);
        }
    }
}