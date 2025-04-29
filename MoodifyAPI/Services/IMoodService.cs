using System.Collections.Generic;
using System.Threading.Tasks;
using MoodifyAPI.Models;  // Ajoutez cette ligne

namespace MoodifyAPI.Services;

public interface IMoodService
{
    Task<IEnumerable<Mood>> GetAllMoodsAsync();
    Task<Mood?> AddMoodAsync(Mood mood);
    Task<IEnumerable<Music>?> GetPlaylistByFeelingAsync(string feeling);
    Task<Mood?> GetMoodWithMusicsAsync(string feeling);
}