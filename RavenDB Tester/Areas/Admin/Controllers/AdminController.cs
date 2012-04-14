using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RavenDB.Models;
using RavenDB.Controllers;

namespace RavenDB.Areas.Admin.Controllers
{
    public class AdminController : RavenController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
