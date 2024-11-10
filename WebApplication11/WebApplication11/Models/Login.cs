using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication11.Models
{
    public class Login
    {
        public string UserID { get; set; }
        public string Password { get; set; }
        Login() { }
        Login(string userId,string password)
        {
            this.UserID = userId;
            this.Password = password;
        }
        List<Login> logins = new List<Login>()
        {
            new Login("naruto","leaf"),
            new Login("luffy","merry")
        };
    }
}