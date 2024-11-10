using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class ListMovieController : Controller
    {
        dbDiscShopEntities dse = new dbDiscShopEntities();
        // GET: ListMovie
        public ActionResult DisplayDisc()
        {
            DiscMovieCollection disc = new DiscMovieCollection();
            disc.movies = dse.movies.ToList();
            return View(disc);
        }
        [HttpPost]
        public string DisplayDisc(FormCollection myForm)
        {
            int id = Convert.ToInt32(myForm["movies"]);
            string name = dse.movies.Where(m => m.id == id).Select(m => m.name).First().ToString();
            return name;
        }
    }
}