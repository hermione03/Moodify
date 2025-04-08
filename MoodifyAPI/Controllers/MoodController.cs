using Microsoft.AspNetCore.Mvc;
using MoodifyAPI.Models;

namespace MoodifyAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoodController : ControllerBase
    {
        private static List<Mood> moods = new List<Mood>
        {
            new Mood { Id = 1, Feeling = "Happy", SuggestedSong = "Happy - Pharrell Williams" },
            new Mood { Id = 2, Feeling = "Sad", SuggestedSong = "Someone Like You - Adele" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Mood>> GetAllMoods()
        {
            return Ok(moods);
        }

        [HttpPost]
        public ActionResult<Mood> AddMood(Mood mood)
        {
            mood.Id = moods.Count + 1;
            moods.Add(mood);
            return CreatedAtAction(nameof(GetAllMoods), new { id = mood.Id }, mood);
        }
    }
}
