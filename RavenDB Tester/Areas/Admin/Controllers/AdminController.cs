using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RavenDB.Models;

namespace RavenDB.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            menuItems.Add(new MenuItem() { DisplayName = "Users", Action = "Index", Controller = "User" });
            return PartialView("Render", menuItems);
        }
    }
}
