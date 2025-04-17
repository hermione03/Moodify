namespace MoodifyAPI.Models;

public class Mood
{
    public int Id { get; set; }
    public string Feeling { get; set; } = string.Empty;
    public ICollection<Music>? Musics { get; set; }
}

