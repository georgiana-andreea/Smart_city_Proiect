using Aplicatie_SmartCity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicatie_SmartCity.EntityConfigurations
{
    public class PubeleConfiguration : IEntityTypeConfiguration<Pubele>
    {
        public void Configure(EntityTypeBuilder<Pubele> builder)
        {

            builder.Property(p => p.Nume)
              .HasColumnType("varchar(100")
              .HasMaxLength(100)
              .IsRequired();
        }

    }
}

