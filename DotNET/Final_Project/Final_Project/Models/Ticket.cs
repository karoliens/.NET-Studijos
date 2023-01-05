namespace Final_Project.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Device Device { get; set; }
    }
}
