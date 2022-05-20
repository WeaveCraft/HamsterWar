using AutoMapper;
using HamsterApp.Entities.DTO.Hamster;
using HamsterApp.Entities.Models;

namespace HamsterApp.API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<HamsterCreateDto, Hamster>().ReverseMap();
            CreateMap<HamsterUpdateDto, Hamster>().ReverseMap();
            CreateMap<HamsterReadOnlyDto, Hamster>().ReverseMap();
        }
    }
}
