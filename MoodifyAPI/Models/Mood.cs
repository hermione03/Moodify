namespace MoodifyAPI.Models;

public class Mood
{
    public int Id { get; set; }
    public string Feeling { get; set; }
    public List<Music> Musics { get; set; } = new();
}