using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnderstandingEFProject.Models;

namespace UnderstandingEFProject.Controllers
{
    public class LoginController : Controller
    {
        NorthwindEntities loginentities = new NorthwindEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View(loginentities.LoginDetails);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(LoginDetail loginDetail)
        {
            loginentities.LoginDetails.Add(loginDetail);
            loginentities.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
