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

        public Ticket(int ticketId, string description, DateTime  createDatetime)
        {
            TicketId = ticketId;
            Description = description;
            CreateDateTime = createDatetime;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TicketId { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public Client? Client { get; set; }
        public List<RepairCategory> RepairCategories { get; set; }
        public Technician? Technician { get; set; }

    }
}
