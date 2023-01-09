using Microsoft.AspNetCore.SignalR;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Project.Models
{
    public class Ticket
    {
        public Ticket()
        {
        }

        public Ticket(int ticketId, string email, string phoneNumber, string typeOfRepair, string description, DateTime  createDatetime)
        {
            TicketId = ticketId;
            Email = email;
            PhoneNumber = phoneNumber;
            TypeOfRepair = typeOfRepair;
            Description = description;
            CreateDateTime = createDatetime;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TicketId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string TypeOfRepair { get; set; }
        public string Description { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public User User { get; set; }

    }
}
