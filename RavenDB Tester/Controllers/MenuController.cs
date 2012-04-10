using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RavenDB.Models;

namespace RavenDB.Controllers
{
    public class MenuController : RavenController
    {
        public ActionResult Render(List<MenuItem> menuItems)
        {
            return View(menuItems);
        }
    }
}
