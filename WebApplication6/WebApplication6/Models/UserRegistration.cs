using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models
{
    public class UserRegistration
    {
        [Required(ErrorMessage = "Username cannot be empty")]
        public string username { get; set; }

        [Required(ErrorMessage = "Password cannot be empty")]

        public string password { get; set; }
        [Compare("password", ErrorMessage = "Password Mismatch")]
        public string retypePassword { get; set; }
        public string name { get; set; }
        public Nullable<int> age { get; set; }
        public List<UserRole> roleList { get; set; }
        public string role { get; set; }
        public string isActive { get; set; }
    }
}