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
            ClientId = ticket.ClientId;
            TechnicianId = ticket.TechnicianId;
            DeviceId = ticket.DeviceId;
            RepairCategories = ticket.RepairCategories
                .Select(rc => new GetRepairCategoryDTO(rc))
                .ToList();
        }
        public string Description { get; set; }
        public int? ClientId { get; set; }
        public int? TechnicianId { get; set; }
        public int? DeviceId { get; set; }
        public Client? Client { get; set; }
        public List<GetRepairCategoryDTO> RepairCategories { get; set; } = new List<GetRepairCategoryDTO>();
        public Technician? Technician { get; set; }
        public Device Device { get; set; }
    }
}
