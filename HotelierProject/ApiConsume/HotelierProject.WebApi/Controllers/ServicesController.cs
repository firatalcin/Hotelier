using HotelierProject.Business.Abstract;
using HotelierProject.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ServicesController : ControllerBase
	{
		private readonly IServiceService _serviceService;

		public ServicesController(IServiceService serviceService)
		{
			_serviceService = serviceService;
		}

		[HttpGet]
		public IActionResult ServiceList()
		{
			var values = _serviceService.GetAll();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult AddService(Service service)
		{
			_serviceService.Add(service);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteService(int id)
		{
			var values = _serviceService.GetById(id);
			_serviceService.Delete(values);
			return Ok();
		}

		[HttpPut]
		public IActionResult UpdateService(Service service)
		{
			_serviceService.Update(service);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult GetService(int id)
		{
			var values = _serviceService.GetById(id);
			return Ok(values);
		}
	}
}
