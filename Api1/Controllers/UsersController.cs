using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET: api/Users
        [HttpGet]
        public IEnumerable<Models.UserModel> Get()
        {
            return Models.UserModel.Users;
        }

        // GET: api/Users/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var user = Models.UserModel.Users.FirstOrDefault(u => u.Id == id);
            if(user != null)
            {
                return Ok(user);
            }
            return NotFound();
        }

        // POST: api/Users
        [HttpPost]
        public void Post([FromBody] Models.UserModel user)
        {
            user.Id = ++Models.UserModel.IdSequence;
            Models.UserModel.Users.Add(user);
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Models.UserModel user)
        {
            var oldUser = Models.UserModel.Users.FirstOrDefault(u => u.Id == id);
            if (oldUser != null)
            {
                Models.UserModel.Users.Remove(oldUser);
                Models.UserModel.Users.Insert(id - 1, user);
                return Ok();
            }
            return NotFound();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var oldUser = Models.UserModel.Users.FirstOrDefault(u => u.Id == id);
            if (oldUser != null)
            {
                Models.UserModel.Users.Remove(oldUser);
                return Ok();
            }
            return NotFound();
        }
    }
}
