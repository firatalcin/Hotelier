using HotelierProject.Business.Abstract;
using HotelierProject.DataAccess.Abstract;
using HotelierProject.Entities.Concrete;

namespace HotelierProject.Business.Concrete
{
    public class StaffManager : ITestimonialService<Staff>, IStaffService
    {
        private readonly IStaffDal _staffDal;
        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public void Add(Staff entity)
        {
            _staffDal.Add(entity);
        }

        public void Delete(Staff entity)
        {
            _staffDal.Delete(entity);
        }

        public List<Staff> GetAll()
        {
            return _staffDal.GetAll();  
        }

        public Staff GetById(int id)
        {
            return _staffDal.GetById(id);
        }

        public void Update(Staff entity)
        {
            _staffDal.Update(entity);
        }
    }
}
