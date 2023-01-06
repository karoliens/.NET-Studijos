namespace Rest_Endpoints.Models
{
    public class Fan
    {
        public Fan(int id, Sport sport)
        {
            Id = id;
            Sport = sport;
        }

        public int Id { get; set; }
        public Sport Sport { get; set; }
    }
}
