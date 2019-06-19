using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsAndControllers.Controllers
{
    public class RandomNumberController : Controller
    {
        // GET: RandomNumber
        public ActionResult Index()
        {
            return View(viewName: "Index", model: 0);
        }

        [HttpPost]
        public ActionResult GenerateRandomNumber(int inputNumber, int inputNumber2)
        {
            Random gen = new Random();
            if (inputNumber < inputNumber2)
            {
                return View(viewName: "Index", model: gen.Next(inputNumber, inputNumber2));
            }
            else
            {
                return View(viewName: "Index", model: gen.Next(inputNumber2, inputNumber));
            }
        }
    }
}