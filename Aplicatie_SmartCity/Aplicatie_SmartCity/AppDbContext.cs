using Aplicatie_SmartCity.Entities;
using Aplicatie_SmartCity.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicatie_SmartCity
{
    namespace CreateDatabaseFromModel_CodeFirstApproach.DataLayer
    {
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions
        <AppDbContext> options) : base(options)
            {
            }

            public DbSet<Sector> Sector { get; set; }
            public DbSet<Pubele> Pubele{ get; set; }

            public DbSet<Zone> Zone { get; set; }

            public DbSet<RaportTeren> RaportTeren { get; set; }



           


            //protected override void OnModelCreating(ModelBuilder modelBuilder)
            //{
            //    modelBuilder.ApplyConfiguration(new DeveloperEntityConfiguration());
            //}
        }

    }

}
