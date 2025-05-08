using RestaurantManagement.DAL;
using RestaurantManagement.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class Repository<T> where T : class
    {
        protected readonly RestaurantDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public Repository()
        {
            _context = new RestaurantDbContext();
            _dbSet = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        public void Attach(T entity)
        {
            _dbSet.Attach(entity);
        }

    }
}
