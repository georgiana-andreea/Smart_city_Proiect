using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicatie_SmartCity.Entities
{
    public class Utilizator :IdentityUser<Guid>
    {
        public ICollection<RoluriUtilizator> RoluriUtilizator { get; set; }
    }
}
