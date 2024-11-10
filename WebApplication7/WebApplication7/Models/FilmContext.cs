using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class FilmContext:DbContext
    {
        public FilmContext():base("name=efConn") { }
        
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Disc> Discs { get; set; }
    }
}