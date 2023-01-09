using Final_Project.Models;

namespace Final_Project.Dto
{
    public class CreateTicketDTO
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string TypeOfRepair { get; set; }
        public string Description { get; set; }
    }
}
