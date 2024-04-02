using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.Address.Request
{
    public class CreateAddressRequest
    {
        public string AddressDetail { get; set; }
        public Guid? CityId { get; set; }
        public Guid? CountryId { get; set; }
        public Guid? DistrictId { get; set; }
        public Guid? NeighborhoodId { get; set; }
    }
}
