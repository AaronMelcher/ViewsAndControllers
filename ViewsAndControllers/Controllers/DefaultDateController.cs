using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsAndControllers.Controllers
{
    public class DefaultDateController : Controller
    {
        // GET: DefaultDate
        public ActionResult Index()
        {
            return View(viewName: "Index", model: "");
        }

        public ActionResult DisplayTodaysDate()
        {
            return View(viewName: "Index", model: DateTime.Today.ToString("MM/dd/yy"));
        }
    }
}