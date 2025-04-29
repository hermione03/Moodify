namespace MoodifyAPI.Models;

public class Music
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Artist { get; set; }
    public int Year { get; set; }
    public int MoodId { get; set; }
    public Mood Mood { get; set; }
}