using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class UserLoginController : Controller
    {
        dbDiscShopEntities dse = new dbDiscShopEntities();
        // GET: UserLogin
        public ActionResult UserLogin()
        {
            ViewBag.Error = "";
            return View();
        }
        [HttpPost]
        public ActionResult UserLogin(user user)
        {
            proc_LoginCheck_Result userdata = null;
            try
            {
                userdata = dse.proc_LoginCheck(user.username, user.password).First();
            }
            catch(Exception)
            {
                ViewBag.Error = "Invalid username or password";
                return View();
            }
            return RedirectToAction("UserHome", userdata);
        }
        public ActionResult UserHome(proc_LoginCheck_Result user)
        {
            return View(user);
        }
    }
}