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
        public ActionResult<GetTicketDTO> GetTicketById(int ticketId)
        {
            if (ticketId == 0)
            {
                return BadRequest();
            }

            var foundTicket = _db.Tickets.FirstOrDefault(t => t.TicketId == ticketId);

            if (foundTicket == null)
            {
                return NotFound();
            }

            return new GetTicketDTO(foundTicket);
        }
        
        [HttpPost("tickets")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<CreateTicketDTO> CreateTicket(CreateTicketDTO ticketDTO)
        {
            if (ticketDTO == null)
            {
                return BadRequest();
            }

            Ticket model = new()
            {
                Email = ticketDTO.Email,
                PhoneNumber = ticketDTO.PhoneNumber,
                TypeOfRepair = ticketDTO.TypeOfRepair,
                Description = ticketDTO.Description,
            };

            _db.Tickets.Add(model);
            _db.SaveChanges();

            return CreatedAtRoute("GetDish", new { id = model.TicketId }, ticketDTO);
        }
        
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
