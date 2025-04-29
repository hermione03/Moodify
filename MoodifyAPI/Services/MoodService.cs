using Microsoft.EntityFrameworkCore;
using MoodifyAPI.Models;
using MoodifyAPI.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoodifyAPI.Services;

public class MoodService : IMoodService
{
    private readonly MoodifyDbContext _context;

    public MoodService(MoodifyDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Mood>> GetAllMoodsAsync()
    {
        return await _context.Moods
            .Include(m => m.Musics)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Mood?> AddMoodAsync(Mood mood)
    {
        _context.Moods.Add(mood);
        await _context.SaveChangesAsync();
        return mood;
    }

    public async Task<IEnumerable<Music>?> GetPlaylistByFeelingAsync(string feeling)
    {
        var mood = await GetMoodWithMusicsAsync(feeling);
        return mood?.Musics;
    }

    public async Task<Mood?> GetMoodWithMusicsAsync(string feeling)
    {
        return await _context.Moods
            .Include(m => m.Musics)
            .FirstOrDefaultAsync(m => m.Feeling.ToLower() == feeling.ToLower());
    }
}