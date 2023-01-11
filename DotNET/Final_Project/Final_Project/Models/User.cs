using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class User
    {
        public User()
        {
        }

        public User(int userId, string userName, string name, int ticketId)
        {
            UserId = userId;
            UserName = userName;
            Name = name;
            TicketId = ticketId;
        }

        public int TicketId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
