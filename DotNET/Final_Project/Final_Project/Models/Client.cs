using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Client
    {
        public Client()
        {
        }

        public Client(int id, string name, string email, string phoneNumber, int ticketId)
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            TicketId = ticketId;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int TicketId { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
