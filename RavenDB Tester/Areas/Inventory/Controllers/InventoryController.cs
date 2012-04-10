using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RavenDB.Models;

namespace RavenDB.Controllers
{
    public class InventoryController : RavenController
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddItem()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddItem(Item item)
        {
            RavenSession.Store(item);
            return RedirectToAction("Index");
        }
    }
}
