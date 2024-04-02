using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.Address.Response
{
    public class GetListAddressResponse
    {
        public string AddressDetail { get; set; }
        public string? CityName { get; set; }
        public string? CountryName { get; set; }
        public string? DistrictName{ get; set; }
        public string? NeighborhoodName { get; set; }
    }
}
