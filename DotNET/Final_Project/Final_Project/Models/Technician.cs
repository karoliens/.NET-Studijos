using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Technician
    {
        public Technician()
        {
        }

        public Technician(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
