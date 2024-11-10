using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult DisplayProducts()
        {
            List<Product> products = new List<Product>()
            {
                new Product() { Id = 101,Name="Naruto",Price=59.6f },
                new Product() { Id = 101, Name = "Naruto", Price = 59.6f },
                new Product() { Id = 101, Name = "Naruto", Price = 59.6f }
            };
            return View(products);
        }
        [HandleError]
        [AllowAnonymous]
        public ActionResult AnotherProduct()
        {
            int num1 = 0, num2 = 10, result = 0;
            result = num2 / num1;
            return View();
        }
    }
}