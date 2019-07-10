using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class UserController : ApiController
    {
        public User[] users = new User[]
        {
            new User{ id = 1, name = "Sam", email = "sam@orb.com", phone = "0011223344", role = 1},
            new User{ id = 2, name = "John", email = "john@orb.com", phone = "0099887766", role = 2},
            new User{ id = 3, name = "Mathew", email = "mathew@orb.com", phone = "0022446688", role = 3},
        };

        // GET: api/User
        public IEnumerable<User> Get()
        {
            return users;
        }

        // GET: api/User/5
        public IHttpActionResult Get(int id)
        {
            var user = users.FirstOrDefault((p) => p.id == id);
            if(user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }


        //// GET: api/User
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/User/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
