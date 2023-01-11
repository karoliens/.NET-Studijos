namespace Final_Project.Models
{
    public class RepairCategory
    {
        public RepairCategory()
        {
        }

        public RepairCategory(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
