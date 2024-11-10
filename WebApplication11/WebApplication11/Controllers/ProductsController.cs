using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class ProductsController : ApiController
    {
        NorthwindEntities db = new NorthwindEntities();
        public List<Product> GetProducts(int price)
        {
            List<Product> products = db.Products.Where(p => p.UnitPrice < price).ToList();
            return products;
        }
    }
}
