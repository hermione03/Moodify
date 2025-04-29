namespace MoodifyAPI.DTOs;

public class MusicDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Artist { get; set; }
    public int Year { get; set; }
    // Pas de référence à Mood pour éviter les cycles
}