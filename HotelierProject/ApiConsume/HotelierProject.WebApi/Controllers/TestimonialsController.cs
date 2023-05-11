using HotelierProject.Business.Abstract;
using HotelierProject.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestimonialsController : ControllerBase
	{
		private readonly ITestimonialService _testimonialService;

		public TestimonialsController(ITestimonialService testimonialService)
		{
			_testimonialService = testimonialService;
		}

		[HttpGet]
		public IActionResult TestimonialList()
		{
			var values = _testimonialService.GetAll();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult AddTestimonial(Testimonial testimonial)
		{
			_testimonialService.Add(testimonial);
			return Ok();
		}

		[HttpDelete]
		public IActionResult DeleteTestimonial(int id)
		{
			var values = _testimonialService.GetById(id);
			_testimonialService.Delete(values);
			return Ok();
		}

		[HttpPut]
		public IActionResult UpdateTestimonial(Testimonial testimonial)
		{
			_testimonialService.Update(testimonial);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult GetTestimonial(int id)
		{
			var values = _testimonialService.GetById(id);
			return Ok(values);
		}
	}
}
