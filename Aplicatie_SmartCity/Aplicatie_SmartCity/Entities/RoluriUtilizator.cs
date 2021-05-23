using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicatie_SmartCity.Entities
{
    public class RoluriUtilizator :IdentityUser<Guid>
    {
        public Utilizator Utilizator { get; set; }
        public Roluri Roluri { get; set; }
    }
}
