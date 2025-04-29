using Microsoft.AspNetCore.Mvc;
using MoodifyAPI.DTOs;
using MoodifyAPI.Models;
using MoodifyAPI.Services;
using AutoMapper;

namespace MoodifyAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MoodController : ControllerBase
{
    private readonly IMoodService _moodService;
    private readonly IMapper _mapper;

    public MoodController(IMoodService moodService, IMapper mapper)
    {
        _moodService = moodService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<MoodDto>>> GetAllMoods()
    {
        var moods = await _moodService.GetAllMoodsAsync();
        return Ok(_mapper.Map<IEnumerable<MoodDto>>(moods));
    }

    [HttpPost]
    public async Task<ActionResult<MoodDto>> AddMood([FromBody] CreateMoodDto createDto)
    {
        var mood = _mapper.Map<Mood>(createDto);
        var addedMood = await _moodService.AddMoodAsync(mood);

        return CreatedAtAction(
            nameof(GetAllMoods),
            _mapper.Map<MoodDto>(addedMood)
        );
    }

    [HttpGet("playlist/{feeling}")]
    public async Task<ActionResult<MoodDto>> GetPlaylist(string feeling)
    {
        var mood = await _moodService.GetMoodWithMusicsAsync(feeling);
        if (mood == null) return NotFound();

        return Ok(_mapper.Map<MoodDto>(mood));
    }
}