using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoodifyAPI.Models;
using MoodifyAPI.Data;
using System.Linq;

namespace MoodifyAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoodController : ControllerBase
    {
        private readonly MoodifyDbContext _context;

        public MoodController(MoodifyDbContext context)
        {
            _context = context;
        }

        // Endpoint pour obtenir toutes les humeurs et musiques associées
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mood>>> GetAllMoods()
        {
            var moods = await _context.Moods
                                      .Include(m => m.Musics)
                                      .ToListAsync();
            return Ok(moods);
        }

        // Endpoint pour ajouter une humeur et ses musiques
        [HttpPost]
        public async Task<ActionResult<Mood>> AddMood(Mood mood)
        {
            _context.Moods.Add(mood);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAllMoods), new { id = mood.Id }, mood);
        }

        // Endpoint pour obtenir une playlist basée sur l'humeur
        [HttpGet("playlist/{feeling}")]
        public async Task<ActionResult<IEnumerable<Music>>> GetPlaylist(string feeling)
        {
            var mood = await _context.Moods
                                     .Include(m => m.Musics)
                                     .FirstOrDefaultAsync(m => m.Feeling.ToLower() == feeling.ToLower());

            if (mood == null)
            {
                return NotFound($"No mood found for '{feeling}'");
            }

            return Ok(mood.Musics);
        }
    }
}
