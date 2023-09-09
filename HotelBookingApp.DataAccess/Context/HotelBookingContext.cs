using HotelBookignApp.Entity;
using HotelBookingApp.DataAccess.Configuraitons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace HotelBookingApp.DataAccess.Context
{
    public class HotelBookingContext : DbContext
    {
        public HotelBookingContext(DbContextOptions<HotelBookingContext> options) : base(options) 
        {
                
        }
        public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<HotelBookingContext>
        {
            public HotelBookingContext CreateDbContext(string[] args)
            {
                var builder = new DbContextOptionsBuilder<HotelBookingContext>();
                var connectionString = "Server = GODSWHIP\\SQLEXPRESS; Database = HotelBookingDb; Trusted_Connection = True; TrustServerCertificate=True";
                builder.UseSqlServer(connectionString);
                return new HotelBookingContext(builder.Options);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)// oluşturduğumuz configuraitonları burada tanıtmamız gerekiyor bu yüzden onmodelcreatng metodunu overide ettik
        {
            modelBuilder.ApplyConfiguration(new PropertiesConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationConfiguraiton());
            modelBuilder.ApplyConfiguration(new RoomConfiguration());
            modelBuilder.ApplyConfiguration(new RoomPropertiesConfiguraiton());
            
        }



        public DbSet<Properties> Propertiess { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomProperties> RoomPropertiess { get; set; }

    }
}
