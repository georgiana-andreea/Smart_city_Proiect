using Aplicatie_SmartCity.CreateDatabaseFromModel_CodeFirstApproach.DataLayer;
using Aplicatie_SmartCity.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicatie_SmartCity.Controllers
{
    [Route("api/Home")]
    
    public class HomeController : ControllerBase
    {
        public readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        [Route("Sector")]
        [HttpGet]
        public IActionResult GetSectoare()
        {
            var sectoare = _context.Sector;
            var result = sectoare.Select(sectorDb => new SectorViewModel
            {
                Nume = sectorDb.Nume,
            });

            return Ok(result);
        }

    }
}
