using HotelierProject.Business.Abstract;
using HotelierProject.DataAccess.Abstract;
using HotelierProject.Entities.Concrete;

namespace HotelierProject.Business.Concrete
{
    public class ServiceManager : ITestimonialService<Service>, IServiceService
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void Add(Service entity)
        {
            _serviceDal.Add(entity);
        }

        public void Delete(Service entity)
        {
            _serviceDal.Delete(entity);
        }

        public List<Service> GetAll()
        {
            return _serviceDal.GetAll();
        }

        public Service GetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public void Update(Service entity)
        {
            _serviceDal.Update(entity);
        }
    }
}
