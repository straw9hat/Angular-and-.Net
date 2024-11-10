using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using UnderstandingEFProject.Models;
using System.Configuration;

namespace UnderstandingEFProject.Controllers
{
    public class ProductController : Controller
    {
        //List<Product> GetProductsFromDatabase()
        //{
        //    List<Product> products = new List<Product>();
        //    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["adoconn"].ConnectionString);
        //    SqlDataAdapter daProducts = new SqlDataAdapter("Select ProductId,ProductName,UnitPrice from products", conn);
        //    DataSet dsProducts = new DataSet();
        //    daProducts.Fill(dsProducts);
        //    Product product;
        //    foreach(DataRow item in dsProducts.Tables[0].Rows)
        //    {
        //        product = new Product();
        //        product.Id = Convert.ToInt32(item[0]);
        //        product.Name = item[1].ToString();
        //        product.Price = Convert.ToDouble(item[2]);
        //        products.Add(product);
        //    }
        //    return products;
        //}
        // GET: Product
        //public ActionResult Index()
        //{
        //    return View(GetProductsFromDatabase());
        //}
    }
}