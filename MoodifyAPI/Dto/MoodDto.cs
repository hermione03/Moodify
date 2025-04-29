namespace MoodifyAPI.DTOs;

public class MoodDto
{
    public int Id { get; set; }
    public string Feeling { get; set; }
    public List<MusicDto> Musics { get; set; } = new();
}