using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using 

namespace WebApplication13.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }

        public Doctor() { }
        public Doctor(int Id,)
    }
}