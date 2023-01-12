using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Device
    {
        public Device()
        {
        }

        public Device(int id, string model, string type)
        {
            Id = id;
            Model = model;
            Type = type;
        }

        public int Id { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Type { get; set; }
    }
}
