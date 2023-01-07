using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class User
    {
        public User()
        {
        }

        public User(int id, string userName, string name, List<Ticket> tickets)
        {
            UserId = id;
            UserName = userName;
            Name = name;
            Tickets = tickets;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        // public byte[] PasswordHash { get; set; }
        // public byte[] PasswordSalt { get; set; }
        // public string Role { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
