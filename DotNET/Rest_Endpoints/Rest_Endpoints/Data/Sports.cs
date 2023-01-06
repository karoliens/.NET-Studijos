using Rest_Endpoints.Models;
using Rest_Endpoints.Models.Dto;

namespace Rest_Endpoints.Data
{
    public static class Sports
    {
        public static List<Sport> sportsList = new List<Sport>()
        {
            new Sport(1, "F1", new List<Athlete>(){new Athlete(3, "Lewis", "Hamilton"), new Athlete(6, "Ayrton", "Senna"),}),
            new Sport(2, "Football", new List<Athlete>(){new Athlete(1, "Thierry", "Henry"), new Athlete(2, "Karim", "Benzema"),}),
            new Sport(3, "Basketball", new List<Athlete>(){new Athlete(4, "Michael", "Jordan"),}),
            new Sport(4, "WRC", new List<Athlete>(){new Athlete(5, "Colin", "McRae"),}),
        };
    }
}
