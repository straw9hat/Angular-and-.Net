using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class RegisterController : Controller
    {
        dbDiscShopEntities dse = new dbDiscShopEntities();
        // GET: Register
        public ActionResult Register()
        {
            UserRegistration userRegister = new UserRegistration();
            userRegister.roleList = new List<UserRole>()
            {
                new UserRole("user","user"),
                new UserRole("admin","admin"),

            };

            return View(userRegister);
        }

        [HttpPost]
        public ActionResult Register(UserRegistration userRegister)
        {
            if (!ModelState.IsValid)
                return View();
            else
            {
                try
                {
                    dse.proc_register_user(userRegister.username, userRegister.password, userRegister.name, userRegister.age, userRegister.role);
                }
                catch (Exception)
                {
                    return View();
                }
                return RedirectToAction("UserLogin");
            }
        }
    }
}