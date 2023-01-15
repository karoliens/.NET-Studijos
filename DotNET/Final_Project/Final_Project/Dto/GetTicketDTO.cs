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
            Description = ticket.Description;
            Client = ticket.Client;
            Technician = ticket.Technician;
            Device = ticket.Device;
            RepairCategories = ticket.RepairCategories;
        }
        public string Description { get; set; }
        public int? ClientId { get; set; }
        public int? TechnicianId { get; set; }
        public int? DeviceId { get; set; }
        public Client? Client { get; set; }
        public List<RepairCategory> RepairCategories { get; set; }
        public Technician? Technician { get; set; }
        public Device Device { get; set; }
    }
}
