using HotelBookignApp.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelBookingApp.DataAccess.Configuraitons
{
    internal class RoomPropertiesConfiguraiton : IEntityTypeConfiguration<RoomProperties>
    {
        public void Configure(EntityTypeBuilder<RoomProperties> builder)
        {
            builder.HasIndex(x => new
            {
                x.PropertiesId,
                x.RoomId,
            });

            builder.HasOne(x => x.Propertiess).WithMany(x => x.RoomProperties).HasForeignKey(x => x.PropertiesId);
            builder.HasOne(x => x.Rooms).WithMany(x => x.RoomProperties).HasForeignKey(x => x.RoomId);
        }
    }
}
