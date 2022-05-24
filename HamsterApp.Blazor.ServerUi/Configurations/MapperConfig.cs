using AutoMapper;
using HamsterApp.Blazor.ServerUi.Services.Base;

namespace HamsterApp.Blazor.ServerUi.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<HamsterReadOnlyDto, HamsterUpdateDto>().ReverseMap();
        }

    }
}
