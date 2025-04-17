namespace MoodifyAPI.Models;

public class Music
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Artist { get; set; } = string.Empty;
    public int MoodId { get; set; } // Foreign key to Mood
    public Mood? Mood { get; set; }
}

