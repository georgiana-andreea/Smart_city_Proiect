using Aplicatie_SmartCity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Aplicatie_SmartCity.EntityConfigurations
{
  
        public class ZoneConfiguration : IEntityTypeConfiguration<Entities.Zone>
        {
            public void Configure(EntityTypeBuilder<Entities.Zone> builder)
            {

                builder.Property(c => c.Nume)
                  .HasColumnType("varchar(100)")
                  .HasMaxLength(100)
                  .IsRequired();

                builder.Property(c => c.SectorId)
                  .HasColumnType("int")
                  .IsRequired();
            }

        }
    
}
