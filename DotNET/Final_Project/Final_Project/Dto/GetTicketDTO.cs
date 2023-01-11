using Final_Project.Models;

namespace Final_Project.Dto
{
    public class GetTicketDTO
    {
        public GetTicketDTO()
        {
        }

        public GetTicketDTO(Ticket ticket)
        {
            Description= ticket.Description;
        }

        public int TicketId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string TypeOfRepair { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public Client Client { get; set; }
    }
}
