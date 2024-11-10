using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class CustomerController : Controller
    {
        static List<Customer> customers = new List<Customer>
        {
            new Customer(101,"Naruto",18,"7869654834"),
            new Customer(102,"Luffy",20,"7806547412"),
            new Customer(103,"Goku",25,"6978239861")
        };
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            return View(customers);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            customers.Add(customer);
            return RedirectToAction("List");
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            Customer customer = customers.Find(c => c.Id == id);
            return View(customer);
        }
        [HttpPost]
        public ActionResult Update(Customer customer)
        {
            int idx = customers.FindIndex(c => c.Id == customer.Id);
            customers[idx].Name = customer.Name;
            customers[idx].Age = customer.Age;
            customers[idx].PhoneNo = customer.PhoneNo;
            return RedirectToAction("List");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Customer customer = customers.Find(c => c.Id == id);
            return View(customer);
        }
        [HttpPost]
        public ActionResult Delete(Customer customer)
        {
            int idx = customers.FindIndex(c => c.Id == customer.Id);
            customers.RemoveAt(idx);
            return RedirectToAction("List");
        }
    }
}