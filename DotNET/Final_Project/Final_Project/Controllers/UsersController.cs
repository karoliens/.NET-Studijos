using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        List<User> DataSeed = new List<User>
        {
                new User { UserId = 1, UserName = "karoliens", Name = "Karolis" },
                new User { UserId = 2, UserName = "ievuzis", Name = "Ieva" },
                new User { UserId = 3, UserName = "tomukas", Name = "Tomas" },
                new User { UserId = 4, UserName = "sauliens", Name = "Saulius" }
            };

        // GET: api/<UsersController>
        [HttpGet]
        public List<User> GetAllUsers()
        {
            return DataSeed;
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public User GetUserById(int id)
        {
            return DataSeed.FirstOrDefault(d => d.UserId == id);
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
