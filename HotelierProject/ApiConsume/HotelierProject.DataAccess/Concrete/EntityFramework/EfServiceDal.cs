using HotelierProject.DataAccess.Abstract;
using HotelierProject.DataAccess.Concrete.Contexts;
using HotelierProject.DataAccess.Concrete.Repositories;
using HotelierProject.Entities.Concrete;

namespace HotelierProject.DataAccess.Concrete.EntityFramework
{
    public class EfServiceDal : GenericRepository<Service>, IServiceDal
    {
        public EfServiceDal(ProjectContext context) : base(context)
        {
        }
    }
}
