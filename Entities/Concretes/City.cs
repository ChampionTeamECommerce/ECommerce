using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class City : Entity<Guid>
    {
        public string Name { get; set; }
        public Guid CountryId { get; set; }

        public virtual Country? Country { get; set; }
      

    }
}
