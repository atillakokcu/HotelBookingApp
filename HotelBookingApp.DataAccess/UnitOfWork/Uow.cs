using HotelBookignApp.Entity;
using HotelBookingApp.DataAccess.Context;
using HotelBookingApp.DataAccess.Interfaces;
using HotelBookingApp.DataAccess.Repository;

namespace HotelBookingApp.DataAccess.UnitOfWork
{
    public class Uow : IUow
    {
        private readonly HotelBookingContext _contex;

        public Uow(HotelBookingContext contex)
        {
            _contex = contex;
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new Repository<T>(_contex);
        }

        public async Task SaveChangesAsync()
        {
            await _contex.SaveChangesAsync();
        }

    }
}
