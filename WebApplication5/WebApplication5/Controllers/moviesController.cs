using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class moviesController : Controller
    {
        dbDiscShopEntities dse = new dbDiscShopEntities();
        // GET: movies
        public ActionResult Index()
        {
            return View(dse.movies);
        }
    }
}