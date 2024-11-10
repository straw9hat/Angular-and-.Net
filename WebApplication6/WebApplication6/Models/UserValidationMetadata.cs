using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models
{
    [MetadataType(typeof(UserValidationMetadata))]
    public partial class user
    {

    }
    public class UserValidationMetadata
    {
        [Required(ErrorMessage = "Username cannot be empty")]
        public string username { get; set; }
        [Required(ErrorMessage = "Password cannot be empty")]
        [MinLength(3, ErrorMessage = "Minimum 3 chars should be present")]

        public string password { get; set; }
    }
}