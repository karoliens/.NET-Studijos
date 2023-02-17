using Final_Project.Data;
using Final_Project.Dto;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Mime;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly RepairShopContext _db;

        public ClientController(RepairShopContext db)
        {
            _db = db;
        }

        [HttpGet("clients/{id:int}", Name = "GetClientById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<GetClientDTO> GetClientById(int clientId)
        {
            if (clientId == 0)
            {
                return BadRequest();
            }

            var foundClient = _db.Clients
                .FirstOrDefault(t => t.ClientId == clientId);

            if (foundClient == null)
            {
                return NotFound();
            }

            return new GetClientDTO(foundClient);
        }

        [HttpPost("clients", Name = "AddClient")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public ActionResult<CreateClientDTO> AddClient([FromBody]CreateClientDTO clientDTO)
        {
            if (clientDTO == null)
            {
                return BadRequest();
            }

            Client newClient = new()
            {
                Name = clientDTO.Name,
                Email = clientDTO.Email,
                PhoneNumber = clientDTO.PhoneNumber,
            };

            _db.Clients.Add(newClient);
            _db.SaveChanges();

            return CreatedAtRoute("GetClientById", new { id = newClient.ClientId }, clientDTO);
        }
    }
}
