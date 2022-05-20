using AutoMapper;
using HamsterApp.Entities.DTO;
using HamsterApp.Entities.Models;

namespace HamsterApp.API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<HamsterCreateDto, Hamster>().ReverseMap();
        }
    }
}
