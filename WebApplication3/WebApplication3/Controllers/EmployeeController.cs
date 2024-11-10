using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class EmployeeController : Controller
    {
        static List<Employee> employees = new List<Employee> {
        new Employee(101, "Naruto", 18),
        new Employee(102, "Luffy", 20),
        new Employee(103, "Ichigo", 22)};
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            
            return View(employees);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Create(FormCollection myForm)
        //{
        //    Employee newEmployee = new Employee();
        //    newEmployee.Id = Convert.ToInt32(myForm["id"]);
        //    return View();
        //}
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            employees.Add(employee);
            return RedirectToAction("List");

        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            Employee employee = employees.Find(emp => emp.Id == id);
            return View(employee);
        }
        [HttpPost]
        public ActionResult Update(Employee employee)
        {
            int idx = employees.FindIndex(e => e.Id == employee.Id);
            employees[idx].Name = employee.Name;
            employees[idx].Age = employee.Age;
            return RedirectToAction("List");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Employee employee = employees.Find(emp => emp.Id == id);
            return View(employee);
        }
        [HttpPost]
        public ActionResult Delete(Employee employee)
        {
            int idx = employees.FindIndex(e => e.Id == employee.Id);
            employees.RemoveAt(idx);
            return RedirectToAction("List");
        }
    }
}