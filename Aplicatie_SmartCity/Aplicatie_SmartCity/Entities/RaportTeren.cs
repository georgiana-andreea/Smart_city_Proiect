using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicatie_SmartCity.Entities
{
    public class RaportTeren
    {
        public int Id { get; set; }

        public int StareIncarcare { get; set; }

        public int ZonaId { get; set; }
        public Zone Zona { get; set; }

        public int PubelaId { get; set; }
        public Pubele Pubela { get; set; }
    }
}
