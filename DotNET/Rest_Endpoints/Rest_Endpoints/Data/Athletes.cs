using Rest_Endpoints.Models;
using Rest_Endpoints.Models.Dto;

namespace Rest_Endpoints.Data
{
    public static class Athletes
    {
        public static List<Athlete> athletesList = new List<Athlete>()
        {
            new Athlete(1, "Thierry", "Henry"),
            new Athlete(2, "Karim", "Benzema"),
            new Athlete(3, "Lewis", "Hamilton"),
            new Athlete(4, "Michael", "Jordan"),
            new Athlete(5, "Colin", "McRae"),
            new Athlete(6, "Ayrton", "Senna"),
        };
    }
}
