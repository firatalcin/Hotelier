using HotelierProject.Business.Abstract;
using HotelierProject.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

		public StaffController(IStaffService staffService)
		{
			_staffService = staffService;
		}

		[HttpGet]
        public IActionResult StaffList()
        {
            var values = _staffService.GetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
            _staffService.Add(staff);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteStaff()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateStaff()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetStaff()
        {
            return Ok();
        }
    }
}
