using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Address :Entity<Guid>
    {
        public string AddressDetail { get; set; }
        public Guid? CityId { get; set; }
        public Guid? CountryId { get; set; }
        public Guid? DistrictId { get; set; }
        public Guid? NeighborhoodId { get; set; }

        public virtual City? City { get; set; }
        public virtual Country? Country { get; set; }
        public virtual District? District { get; set; }
        public virtual Neighborhood? Neighborhood { get; set; }
        public virtual UserAddresses UserAddresses { get; set; }


    }
}
