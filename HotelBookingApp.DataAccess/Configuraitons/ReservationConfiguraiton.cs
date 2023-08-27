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
    public class ReservationConfiguraiton : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.EndDate).IsRequired();
            builder.Property(x=>x.Name).IsRequired().HasMaxLength(20);
            builder.Property(x=>x.Surname).IsRequired().HasMaxLength(20);
            builder.Property(x=>x.MailAdress).IsRequired().HasMaxLength(50);
            builder.Property(x=>x.PhoneNumber).IsRequired().HasMaxLength(50);
            builder.Property(x=>x.MessageText).IsRequired().HasMaxLength(500);

            builder.HasOne(x => x.Room).WithMany(x => x.Reservation).HasForeignKey(x => x.RoomId);
        }
    }
}
