using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApplication13.Models;

namespace WebApplication13.Controllers
{
    [EnableCors(origins: "http://localhost:57272", headers: "*", methods: "*")]
    public class StudentController : ApiController
    {
        static List<Student> students = new List<Student>()
        {
        new Student(101,"Ramu",59 ),
        new Student(101,"Ramu",59 ),
        new Student(101,"Ramu",59 )
         };
        // GET: api/Student
        public IEnumerable<Student> Get()
        {
            return students;
        }

        // GET: api/Student/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Student
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
