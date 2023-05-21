using AutoMapper;
using HotelierProject.Dto.Dtos.RoomDto;
using HotelierProject.Entities.Concrete;

namespace HotelierProject.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<AddRoomDto, Room>().ReverseMap();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();
        }
    }
}
