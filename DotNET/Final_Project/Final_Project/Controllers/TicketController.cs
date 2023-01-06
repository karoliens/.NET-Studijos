using Final_Project.Data;
using Final_Project.Dto;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly RepairShopContext _db;

        public TicketController(RepairShopContext db)
        {
            _db = db;
        }
        
        List<Ticket> DataSeed = new List<Ticket>
        {
                new Ticket { TicketId = 1, Email = "karoliens@gmail.com", PhoneNumber = "" },
                new Ticket { TicketId = 2, Email = "ievuzis@gmail.com", PhoneNumber = "" },
                new Ticket { TicketId = 3, Email = "tomukas@gmail.com", PhoneNumber = "" },
                new Ticket { TicketId = 4, Email = "sauliens@gmail.com", PhoneNumber = "" }
            };
        
        // GET: api/<TicketController>
        [HttpGet]
        public List<GetTicketDTO> GetAllTickets()
        {
            return _db.Tickets.Select(t => new GetTicketDTO(t)).ToList();
        }

        // GET api/<TicketController>/5
        [HttpGet("{id}")]
        public GetTicketDTO GetTicketById(int id)
        {
            var ticket = _db.Tickets.FirstOrDefault(t => t.TicketId == id);

            return new GetTicketDTO(ticket);
        }
        // POST api/<TicketController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TicketController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TicketController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
