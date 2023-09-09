using HotelBookignApp.Entity;
using HotelBookingApp.DataAccess.Context;
using HotelBookingApp.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HotelBookingApp.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly HotelBookingContext _contex;

        public Repository(HotelBookingContext contex)
        {
            _contex = contex;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _contex.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter)
        {
            return await _contex.Set<T>().AsNoTracking().Where(filter).ToListAsync();
        }

        public async Task<T> FindAsync(object id)
        {
            return await _contex.Set<T>().FindAsync(id);

        }

        public async Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter, bool asNoTracking = false)
        {
            return !asNoTracking? await _contex.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter): await _contex.Set<T>().SingleOrDefaultAsync(filter);
        }

        public IQueryable<T> GetQuery()
        {
            return _contex.Set<T>().AsQueryable();
        }

        public void Remove (T item)
        {
            _contex.Set<T>().Remove(item);
        }

        public async Task CreateAsync(T item)
        {
            await _contex.Set<T>().AddAsync(item);
        }

        public void Update(T entity, T unchanged)
        {
            _contex.Entry(unchanged).CurrentValues.SetValues(entity);
        }


    }
}
