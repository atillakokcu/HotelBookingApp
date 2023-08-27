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
    public class PropertiesConfiguration : IEntityTypeConfiguration<Properties>
    {
        public void Configure(EntityTypeBuilder<Properties> builder)
        {
            builder.Property(x=>x.PropertiesDescription).HasMaxLength(300).IsRequired();

            
        }
    }
}
