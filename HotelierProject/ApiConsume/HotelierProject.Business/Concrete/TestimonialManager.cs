using HotelierProject.Business.Abstract;
using HotelierProject.DataAccess.Abstract;
using HotelierProject.Entities.Concrete;

namespace HotelierProject.Business.Concrete
{
    public class TestimonialManager : ITestimonialService<Testimonial>, ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void Add(Testimonial entity)
        {
            _testimonialDal.Add(entity);
        }

        public void Delete(Testimonial entity)
        {
            _testimonialDal.Delete(entity); 
        }

        public List<Testimonial> GetAll()
        {
            return _testimonialDal.GetAll();    
        }

        public Testimonial GetById(int id)
        {
            return _testimonialDal.GetById(id); 
        }

        public void Update(Testimonial entity)
        {
            _testimonialDal.Update(entity);
        }
    }
}
