using AutoMapper;
using HotelierProject.Business.Abstract;
using HotelierProject.Dto.Dtos.RoomDto;
using HotelierProject.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Validations;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomService _roomService; 
        private readonly IMapper _mapper; 

        public RoomsController(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            var values = _roomService.GetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddRoom(AddRoomDto addRoomDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                var values = _mapper.Map<Room>(addRoomDto);
                _roomService.Add(values);
                return Ok();
            }
        }

        [HttpDelete]
        public IActionResult DeleteRoom(int id)
        {
            var values = _roomService.GetById(id);
            _roomService.Delete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom(UpdateRoomDto updateRoomDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                var values = _mapper.Map<Room>(updateRoomDto);
                _roomService.Update(values);
                return Ok();
            }


        }

        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var values = _roomService.GetById(id);
            return Ok(values);
        }
    }
}
