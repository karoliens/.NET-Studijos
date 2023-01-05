using Final_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        List<User> DataSeed = new List<User>
        {
                new User { Id = 1, UserName = "karoliens", Name = "Karolis" },
                new User { Id = 2, UserName = "ievuzis", Name = "Ieva" },
                new User { Id = 3, UserName = "tomukas", Name = "Tomas" }, 
                new User { Id = 4, UserName = "sauliens", Name = "Saulius" }
            };



        [HttpGet]
        public List<User> GetUsers()
        {
            return DataSeed;
        }
    }
}
