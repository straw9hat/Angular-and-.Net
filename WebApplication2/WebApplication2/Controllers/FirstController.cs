using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public string MyFiirstMethod()
        {
            return "<h1>Hello</h1>";
        }
        public ActionResult SecondMethod()
        {
            return View();
        }
        public ActionResult PassDataWithViewBag()
        {
            return View();
        }
        public ActionResult MyOwn()
        {
            return View();

        }
    }
}