using HotelierProject.DataAccess.Abstract;
using HotelierProject.DataAccess.Concrete.Contexts;
using HotelierProject.DataAccess.Concrete.Repositories;
using HotelierProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.DataAccess.Concrete.EntityFramework
{
    public class EfRoomDal : GenericRepository<Room>, IRoomDal
    {
        public EfRoomDal(ProjectContext context) : base(context)
        {
        }
    }
}
