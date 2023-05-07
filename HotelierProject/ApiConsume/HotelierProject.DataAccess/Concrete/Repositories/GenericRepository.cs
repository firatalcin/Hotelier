using HotelierProject.DataAccess.Abstract;
using HotelierProject.DataAccess.Concrete.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.DataAccess.Concrete.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ProjectContext _context;

        public GenericRepository(ProjectContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
           _context.Add(entity);
           _context.SaveChanges();
        }

        public void Delete(T entity)
        {
           _context.Remove(entity);
           _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();  
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
