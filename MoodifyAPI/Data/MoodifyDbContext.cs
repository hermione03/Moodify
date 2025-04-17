using Microsoft.EntityFrameworkCore;
using MoodifyAPI.Models;

namespace MoodifyAPI.Data
{
    public class MoodifyDbContext : DbContext
    {
        public MoodifyDbContext(DbContextOptions<MoodifyDbContext> options) : base(options) {}

        public DbSet<Mood> Moods { get; set; }
        public DbSet<Music> Musics { get; set; }
    }
}
