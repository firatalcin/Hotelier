using HotelierProject.Business.Abstract;
using HotelierProject.DataAccess.Abstract;
using HotelierProject.Entities.Concrete;

namespace HotelierProject.Business.Concrete
{
    public class SubscribeManager : ITestimonialService<Subscribe>, ISubscribeService
    {
        private readonly ISubscribeDal _subscribeDal;

        public SubscribeManager(ISubscribeDal subscribeDal)
        {
            _subscribeDal = subscribeDal;
        }

        public void Add(Subscribe entity)
        {
            _subscribeDal.Add(entity);
        }

        public void Delete(Subscribe entity)
        {
            _subscribeDal.Delete(entity);
        }

        public List<Subscribe> GetAll()
        {
            return _subscribeDal.GetAll();
        }

        public Subscribe GetById(int id)
        {
            return _subscribeDal.GetById(id);
        }

        public void Update(Subscribe entity)
        {
            _subscribeDal.Update(entity);   
        }
    }
}
