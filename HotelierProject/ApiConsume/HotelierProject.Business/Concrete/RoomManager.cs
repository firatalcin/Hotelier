using HotelierProject.Business.Abstract;
using HotelierProject.DataAccess.Abstract;
using HotelierProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Business.Concrete
{
    public class RoomManager : ITestimonialService<Room>, IRoomService
    {
        private readonly IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public void Add(Room entity)
        {
            _roomDal.Add(entity);
        }

        public void Delete(Room entity)
        {
            _roomDal.Delete(entity);
        }

        public List<Room> GetAll()
        {
            return _roomDal.GetAll();
        }

        public Room GetById(int id)
        {
            return _roomDal.GetById(id);
        }

        public void Update(Room entity)
        {
            _roomDal.Update(entity);
        }
    }
}
