using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Neighborhood:Entity<Guid>
    {
        public string Name { get; set; }
        public Guid DistrictId { get; set; }

        public virtual Address Address { get; set; }
    }
}
