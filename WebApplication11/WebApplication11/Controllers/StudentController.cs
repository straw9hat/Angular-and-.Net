using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class StudentController : ApiController
    {
        public static List<Student> students = new List<Student>()
        {
            new Student(101,"naruto"),
            new Student(102,"Luffy")
        };
        public List<Student> GetStudents()
        {
            return students;
        }
        public Student GetStudent(int id)
        {
            Student student = students.Find(s => s.Id == id);
            return student;
        }
        public void PostStudent(Student student)
        {
            students.Add(student);
        }
        public void DeleteStudent(int id)
        {
            int idx = students.FindIndex(s => s.Id == id);
            if(idx>=0)
            {
                students.RemoveAt(idx);
            }
        }
    }
}
