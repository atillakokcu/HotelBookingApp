using HotelBookignApp.Entity;
using HotelBookingApp.DataAccess.Interfaces;

namespace HotelBookingApp.DataAccess.UnitOfWork
{
    public interface IUow
    {
        IRepository<T> GetRepository<T>() where T : BaseEntity;
        Task SaveChangesAsync();
    }
}
