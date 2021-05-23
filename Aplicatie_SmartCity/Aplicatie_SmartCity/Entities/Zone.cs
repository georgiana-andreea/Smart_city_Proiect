using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicatie_SmartCity.Entities
{
    public class Zone
    {
        public int Id { get; set; }
        public string Nume { get; set; }

        public int SectorId { get; set; }
        public Sector Sector { get; set; }
    }
}
