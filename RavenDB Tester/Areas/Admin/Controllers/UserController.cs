using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RavenDB.Models;
using RavenDB.Controllers;

namespace RavenDB.Areas.Admin.Controllers
{
    public class UserController : RavenController
    {
        [HttpGet]
        public ActionResult Index()
        {
            var users = RavenSession.Query<UserInfo>().ToList<UserInfo>();
            return View(users);
        }

        [HttpGet]
        public ActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(UserInfo user)
        {
            RavenSession.Store(user);
            return RedirectToAction("Index");
        }



    }
}
