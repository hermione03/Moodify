using AutoMapper;
using MoodifyAPI.DTOs;
using MoodifyAPI.Models;

namespace MoodifyAPI.DTOs;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Mood, MoodDto>();
        CreateMap<Music, MusicDto>();
        CreateMap<CreateMoodDto, Mood>();
    }
}