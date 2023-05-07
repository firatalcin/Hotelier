using HotelierProject.DataAccess.Abstract;
using HotelierProject.DataAccess.Concrete.Contexts;
using HotelierProject.DataAccess.Concrete.Repositories;
using HotelierProject.Entities.Concrete;

namespace HotelierProject.DataAccess.Concrete.EntityFramework
{
    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
        public EfStaffDal(ProjectContext context) : base(context)
        {
        }
    }
}
