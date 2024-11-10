using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication10.Models;

namespace WebApplication10.Controllers
{
    public class USerController : Controller
    {
        // GET: USer
        public ActionResult UserLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserLogin(User user)
        {
            if (user.UserName.Length == 4 && user.Password == "1234")
            {
                TempData["username"] = user.UserName;
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                return RedirectToAction("DisplayProducts", "Product");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid username or password";
                return View();
            }
        }
    }
}