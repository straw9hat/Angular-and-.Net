using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class Movie
    {
        [Key]
        public int MovieNo { get; set; }
        public string Name { get; set; }
        public float Duration { get; set; } 

        public virtual ICollection<Disc> Discs { get; set; }
    }
}