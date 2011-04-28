using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc3CodeFirst.Domain;

namespace Mvc3CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        NerdDinners nerdDinners = new NerdDinners();

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            var dinners = from d in nerdDinners.Dinners
                          where d.EventDate > DateTime.Now
                          select d;

            return View(dinners.ToList());
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
