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
        
        [HttpGet("tickets")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<GetTicketDTO>> GetAllTickets()
        {
            return _db.Tickets.Select(t => new GetTicketDTO(t)).ToList();
        }

        [HttpGet("tickets/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<GetTicketDTO> GetTicketById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var foundTicket = _db.Tickets.FirstOrDefault(t => t.TicketId == id);

            if (foundTicket == null)
            {
                return NotFound();
            }


            return new GetTicketDTO(foundTicket);
        }
        /*
        [HttpPost("tickets")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<CreateTicketDTO> CreateTicket(CreateTicketDTO ticketDTO)
        {
            if (dishDTO == null)
            {
                return BadRequest();
            }

            Ticket model = new()
            {
                Country = dishDTO.Country,
                SpiceLevel = dishDTO.SpiceLevel,
                Type = dishDTO.Type,
                Name = dishDTO.Name,
                CreateDateTime = dishDTO.CreateDateTime,
                ImagePath = dishDTO.ImagePath
            };

            _db.Dishes.Add(model);
            _db.SaveChanges();

            return CreatedAtRoute("GetDish", new { id = model.DishId }, dishDTO);
        }
        */
        [HttpDelete("tickets/delete/{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult DeleteTicketById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var foundTicket = _db.Tickets.FirstOrDefault(d => d.TicketId == id);

            if (foundTicket == null)
            {
                return NotFound();
            }

            _db.Tickets.Remove(foundTicket);
            _db.SaveChanges();

            return NoContent();
        }

        [HttpPut("tickets/update/{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult UpdateTicketById(int id, UpdateTicketDTO updateTicketDTO)
        {
            if (id == 0 || updateTicketDTO == null)
            {
                return BadRequest();
            }

            var foundTicket = _db.Tickets
                .FirstOrDefault(d => d.TicketId == id);

            if (foundTicket == null)
            {
                return NotFound();
            }
            /*
            foundTicket.Name = updateTicketDTO.Name;
            foundTicket.ImagePath = updateTicketDTO.ImagePath;
            foundTicket.Type = updateTicketDTO.Type;
            foundTicket.SpiceLevel = updateTicketDTO.SpiceLevel;
            foundTicket.Country = updateTicketDTO.Country;
            */
            _db.Tickets.Update(foundTicket);
            _db.SaveChanges();

            return NoContent();
        }
    }
}
