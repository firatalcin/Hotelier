using AutoMapper;
using HotelierProject.Entities.Concrete;
using HotelierProject.WebUI.Dtos.LoginDto;
using HotelierProject.WebUI.Dtos.ServiceDto;

namespace HotelierProject.WebUI.Mapping
{
    public class AutoMappingConfig : Profile
    {
        public AutoMappingConfig()
        {
            CreateMap<Service, ResultServiceDto>().ReverseMap();
            CreateMap<Service, CreateServiceDto>().ReverseMap();
            CreateMap<Service, UpdateServiceDto>().ReverseMap();
            CreateMap<AppUser, CreateServiceDto>().ReverseMap();
            CreateMap<AppUser, LoginUserDto>().ReverseMap();
        }

    }
}
