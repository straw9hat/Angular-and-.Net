using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class UserRole
    {
        public string RoleType { get; set; }
        public string RoleName { get; set; }
        public UserRole(string rt, string rn)
        {
            RoleName = rn;
            RoleType = rt;
        }
        public UserRole() { }
    }
}