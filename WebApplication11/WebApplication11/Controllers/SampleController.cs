using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class SampleController : ApiController
    {
        //[HttpGet]
        //public string SayHEllo()
        //{
        //    return "Hello World";
        //}
        [HttpGet]
        public string SayHelloWorld(int id)
        {
            return "HEllo World " + id;
        }
        [HttpGet]
        public string SayHelloWorld(int id, int age)
        {
            return "HEllo World " + id +" "+age;
        }
        [HttpGet]
        //public string SayHelloEveryone(string name, int age,int id)
        //{
        //    return "HEllo World " + age + name + id;
        //}
        public User InfoUser(int id, int age, string name)
        {
            User user = new User();
            user.Id = id;
            user.Age = age;
            user.Name = name;
            return user;
        }
        [HttpGet]
        public List<User> UserList()
        {
            List<User> users = new List<User>()
            {
                new User()
                {
                    Id=1001,
                    Name= "Naruto",
                    Age=16

                },
                new User()
                {
                    Id=1002,
                    Name ="Luffy",
                    Age =18
                }
            };
            return users;
        }
        [HttpPost]
        public string HelloPost()
        {
            return "THis is post";
        }
        [HttpPut]
        public string HelloPut()
        {
            return "THis is put";
        }
        [HttpDelete]
        public string HelloDelete()
        {
            return "THis is delete";
        }
    }
}
