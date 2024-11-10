using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public string MyFirstMethod()
        {
            return "<h1>Hello</h1>";
        }
        public ActionResult SecondMethod()
        {
            return View();
        }
        public ActionResult MyOwn()
        {
            return View();
        }
        public ActionResult PassDataViewWithBag()
        {
            ViewBag.Name = "Nik";
            ViewBag.Something = "strawhat";
            return View();
        }
        public ActionResult PassDataViewWithData()
        {
            ViewData["Name"] = "Nik";
            ViewData["Age"] = "22";
            return View();
        }
        public ActionResult ViewDatavsViewBag()
        {
            List<string> names = new List<string>();
            names.Add("Naruto");
            names.Add("Sasuke");
            names.Add("Itachi");
            names.Add("Kakashi");
            ViewBag.users = names;
            ViewData["users"] = names;
            return View();
        }
    }
}