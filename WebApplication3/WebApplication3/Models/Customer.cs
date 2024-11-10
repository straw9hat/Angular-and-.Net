using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace WebApplication3.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string PhoneNo { get; set; }
        public Customer()
        {

        }
        public Customer(int id, string name, int age, string phoneNo)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.PhoneNo = phoneNo;
        }
    }
}