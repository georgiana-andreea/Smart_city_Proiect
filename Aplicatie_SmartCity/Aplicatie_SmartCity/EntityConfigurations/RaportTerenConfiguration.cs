using Aplicatie_SmartCity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicatie_SmartCity.EntityConfigurations
{
    public class RaportTerenConfiguration : IEntityTypeConfiguration<Entities.RaportTeren>
    {
        public void Configure(EntityTypeBuilder<Entities.RaportTeren> builder)
        {

            builder.Property(d => d.StareIncarcare)
              .HasColumnType("int")
              .IsRequired();

            builder.Property(d => d.ZonaId)
              .HasColumnType("int")
              .IsRequired();

            builder.Property(d => d.PubelaId)
             .HasColumnType("int")
             .IsRequired();
        }

    }
}
