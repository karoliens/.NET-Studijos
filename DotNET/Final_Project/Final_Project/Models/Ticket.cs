using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Project.Models
{
    public class Ticket
    {
        public Ticket()
        {
        }

        public Ticket(int id, string email, string phoneNumber, Device device, string typeOfRepair, string description, User user)
        {
            TicketId = id;
            Email = email;
            PhoneNumber = phoneNumber;
            // Device = device;
            TypeOfRepair = typeOfRepair;
            Description = description;
            User = user;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TicketId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        // public Device Device { get; set; }
        public string TypeOfRepair { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
