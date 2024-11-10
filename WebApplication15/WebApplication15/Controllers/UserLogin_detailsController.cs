using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication15.Models;

namespace WebApplication15.Controllers
{
    public class UserLogin_detailsController : ApiController
    {
        public UserLogin_detailsController()
        {

        }

        private PrjGladEntities db = new PrjGladEntities();

        // GET: api/UserLogin_details
        public IQueryable<UserLogin_details> GetUserLogin_details()
        {
            return db.UserLogin_details;
        }
        // POST: api/UserLogin_details

        public IHttpActionResult PostUserLogin_details(UserLogin_details userLogin_details)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.UserLogin_details.Add(userLogin_details);

            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = userLogin_details.email }, userLogin_details);
        }
    }
}
