using Final_Project.Models;

namespace Final_Project.Dto
{
    public class CreateTicketDTO
    {
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
