namespace Rest_Endpoints.Models
{
    public class Sport
    {
        public Sport(int id, string name, List<Athlete> athletes)
        {
            Id = id;
            Name = name;
            Athletes = athletes;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Athlete> Athletes { get; set; }
    }
}
