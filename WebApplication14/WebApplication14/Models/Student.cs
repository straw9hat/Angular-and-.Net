using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication14.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TestScore { get; set; }

        public Student() { }
        public Student(int id, string name, int score)
        {
            Id = id;
            Name = name;
            TestScore = score;
        }
    }
}