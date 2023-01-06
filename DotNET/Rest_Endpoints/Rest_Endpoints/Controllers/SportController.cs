using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using P02_Rest_Endpoints.Data;
using Rest_Endpoints.Data;
using Rest_Endpoints.Models;
using Rest_Endpoints.Models.Dto;

namespace Rest_Endpoints.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportController : ControllerBase
    {
        [HttpGet("sports")]
        public List<Sport> GetAllSports()
        {
            var sports = Sports.sportsList;

            return sports;
        }

        [HttpGet("sports/{id:int}")]
        public Sport? GetSportById(int id)
        {
            return Sports.sportsList
                .FirstOrDefault(f => f.Id == id);
        }

        [HttpGet("athletes")]
        public List<Athlete> GetAllAthletes()
        {
            var athletes = Athletes.athletesList;

            return athletes;
        }

        [HttpGet("athletes/{id:int}")]
        public Athlete? GetAthleteById(int id)
        {
            return Athletes.athletesList.FirstOrDefault(f => f.Id == id);
        }

        [HttpPost("createathlete")]
        public ActionResult<Sport> CreateSport(Sport sport)
        {
            if (sport == null)
            {
                return BadRequest(sport);
            }

            if (sport.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            var getLastSportId = Sports.sportsList.OrderByDescending(f => f.Id).First().Id;

            sport.Id = getLastSportId + 1;

            Sports.sportsList.Add(sport);

            return CreatedAtRoute("GetFood", new { id = sport.Id },
            sport);
        }

        [HttpPost("createsport")]
        public ActionResult<Athlete> CreateAthlete(Athlete athlete)
        {
            if (athlete == null)
            {
                return BadRequest(athlete);
            }

            if (athlete.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            var getLastSportId = Athletes.athletesList.OrderByDescending(f => f.Id).First().Id;

            athlete.Id = getLastSportId + 1;

            Athletes.athletesList.Add(athlete);

            return CreatedAtRoute("GetFood", new { id = athlete.Id },
            athlete);
        }

        [HttpDelete("sports/delete/{id:int}")]
        public void DeleteSport(int id)
        {
            var sport = Sports.sportsList.FirstOrDefault(f => f.Id == id);

            Sports.sportsList.Remove(sport);
        }

        [HttpDelete("athletes/delete/{id:int}")]
        public void DeleteAthlete(int id)
        {
            var athletes = Athletes.athletesList.FirstOrDefault(f => f.Id == id);

            Athletes.athletesList.Remove(athletes);
        }
    }
}
