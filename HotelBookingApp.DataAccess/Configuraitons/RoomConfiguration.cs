using HotelBookignApp.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.DataAccess.Configuraitons
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            
            builder.Property(x=>x.GuestCapacity).IsRequired();
            builder.Property(x=>x.RoomName).IsRequired();
            builder.Property(x=>x.RoomPrice).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(x => x.RoomSize).IsRequired();
            builder.Property(x=>x.RoomDescription).IsRequired();
            builder.Property(x=>x.RoomImagesMain).IsRequired();
        }
    }
}
