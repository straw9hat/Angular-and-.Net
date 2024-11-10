using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class DiscController : Controller
    {
        dbDiscShopEntities dse = new dbDiscShopEntities();
        // GET: Disc
        public ActionResult Index()
        {
            return View(dse.discs);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(disc newDisc)
        {
            dse.proc_insert_disc(newDisc.movie_id, newDisc.rental_cost);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            disc myDisc = dse.discs.ToList().Find(d => d.id == id);
            return View(myDisc);
        }
        [HttpPost]
        public ActionResult Delete(disc deletedDisc)
        {
            dse.Entry(deletedDisc).State = System.Data.Entity.EntityState.Deleted;
            dse.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}