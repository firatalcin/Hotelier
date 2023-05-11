using HotelierProject.Business.Abstract;
using HotelierProject.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SubscribesController : ControllerBase
	{
		private readonly ISubscribeService _subscribeService;

		public SubscribesController(ISubscribeService SubscribeService)
		{
			_subscribeService = SubscribeService;
		}

		[HttpGet]
		public IActionResult SubscribeList()
		{
			var values = _subscribeService.GetAll();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult AddSubscribe(Subscribe subscribe)
		{
			_subscribeService.Add(subscribe);
			return Ok();
		}

		[HttpDelete]
		public IActionResult DeleteSubscribe(int id)
		{
			var values = _subscribeService.GetById(id);
			_subscribeService.Delete(values);
			return Ok();
		}

		[HttpPut]
		public IActionResult UpdateSubscribe(Subscribe subscribe)
		{
			_subscribeService.Update(subscribe);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult GetSubscribe(int id)
		{
			var values = _subscribeService.GetById(id);
			return Ok(values);
		}
	}
}
