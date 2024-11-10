using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class OrderController : Controller
    {
        NorthwindEntities nwe = new NorthwindEntities();
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DisplayAllOrders()
        {
            List<Order> orders = nwe.Orders.ToList();
            orders.Sort(new OrderSortWithShipCity());
            return View(orders);
        }
        public ActionResult Details(int id)
        {
            Order order = nwe.Orders.Where(o => o.OrderID == id).First();
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Order order = nwe.Orders.Where(o => o.OrderID == id).First();
            return View(order);
        }
        [HttpPost]
        public ActionResult Edit(Order order)
        {
            //Order MyOrder = nwe.Orders.Where(o => o.OrderID == order.OrderID).First();
            nwe.Entry(order).State = System.Data.Entity.EntityState.Modified;
            nwe.SaveChanges();
            return RedirectToAction("DisplayAllOrders");
        }
    }
}