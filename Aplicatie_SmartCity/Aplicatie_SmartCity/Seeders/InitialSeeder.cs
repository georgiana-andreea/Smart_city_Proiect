using Aplicatie_SmartCity.CreateDatabaseFromModel_CodeFirstApproach.DataLayer;
using Aplicatie_SmartCity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicatie_SmartCity.Seeders
{
    
    public class InitialSeeder
    {
        private readonly AppDbContext _context;
        public InitialSeeder(AppDbContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            #region Sectoare

            var existaSectoareDeja = _context.Sector.Any();
            if (!existaSectoareDeja)
            {
                var sector1 = new Sector
                {
                    Nume = "Sector 1"
                };
                var sector2 = new Sector
                {
                    Nume = "Sector 2"
                };
                var sector3 = new Sector
                {
                    Nume = "Sector 3"
                };
                var sector4 = new Sector
                {
                    Nume = "Sector 4"
                };
                var sector5 = new Sector
                {
                    Nume = "Sector 5"
                };
                var sector6 = new Sector
                {
                    Nume = "Sector 6"
                };


                var sectoareDeAdaugat = new List<Sector> { sector1, sector2, sector3, sector4, sector5, sector6 };
                _context.Sector.AddRange(sectoareDeAdaugat);
                _context.SaveChanges();
            }
            #endregion

            #region Pubele
            var existaPubeleDeja = _context.Pubele.Any();
            if (!existaPubeleDeja)
            {
                var pubela_galbena = new Pubele
                {
                    Nume = "Plastic"
                };
                var pubela_verde = new Pubele
                {
                    Nume = "Deseuri organice"
                };
                var pubela_albastra = new Pubele
                {
                    Nume = "Hartie"
                };
                var pubela_portocalie = new Pubele
                {
                    Nume = "Sticla"
                };

                var pubeleDeAdaugat = new List<Pubele> { pubela_galbena, pubela_verde, pubela_albastra, pubela_portocalie };
                _context.Pubele.AddRange(pubeleDeAdaugat);
                _context.SaveChanges();
            }
            #endregion

            #region Zone

            var existaZoneDeja = _context.Zone.Any();
            if (!existaZoneDeja)
            {
                var sectorId = _context.Sector.FirstOrDefault().Id;

                var zona1 = new Zone
                {
                    Nume = "Zona1",
                    SectorId = sectorId
                };
                var zona2 = new Zone
                {
                    Nume = "Zona2",
                    SectorId = sectorId
                };
                var zona3 = new Zone
                {
                    Nume = "Zona3",
                    SectorId = sectorId
                };
                var zona4 = new Zone
                {
                    Nume = "Zona4",
                    SectorId = sectorId
                };
                var zona5 = new Zone
                {
                    Nume = "Zona5",
                    SectorId = sectorId
                };
                var zona6 = new Zone
                {
                    Nume = "Zona6",
                    SectorId = sectorId
                };
                var zona7 = new Zone
                {
                    Nume = "Zona7",
                    SectorId = sectorId
                };
                var zona8 = new Zone
                {
                    Nume = "Zona8",
                    SectorId = sectorId
                };

                var zoneDeAdaugat = new List<Zone> { zona1, zona2, zona3, zona4, zona5, zona6, zona7, zona8 };
                _context.Zone.AddRange(zoneDeAdaugat);
                _context.SaveChanges();
            }
            #endregion

            #region RaportTeren
            var existaRapoarteDeja = _context.RaportTeren.Any();
            
                var zoneId = _context.Zone.FirstOrDefault().Id;
                var pubelaId = _context.Pubele.FirstOrDefault().Id;

               
                var raport5 = new RaportTeren
                {
                    StareIncarcare = 3,
                    ZonaId = 3,
                    PubelaId = 1,
                };
                var raport6 = new RaportTeren
                {
                    StareIncarcare = 2,
                    ZonaId = 4,
                    PubelaId = 2,
                };

                var rapoarteDeAdaugat = new List<RaportTeren> { raport5, raport6 };
                _context.RaportTeren.UpdateRange(rapoarteDeAdaugat);
                _context.SaveChanges();
            
            #endregion
        }
    }
}
