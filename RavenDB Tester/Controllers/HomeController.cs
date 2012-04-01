using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RavenDB_Tester.Controllers
{
    public class HomeController : RavenController
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.ConnectionString = MvcApplication.Store.Url;

            return View();
        }

        public ActionResult Users()
        {

        }
    }
}
