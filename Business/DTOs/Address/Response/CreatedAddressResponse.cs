namespace Business.DTOs.Address.Response
{
    public class CreatedAddressResponse
    {
      public string AddressDetail { get; set; }
        public string? CityName { get; set; }
        public string? CountryName { get; set; }
        public string? DistrictName { get; set; }
        public string? NeighborhoodName { get; set; }
    }
}
