namespace Business.DTOs.Address.Request
{
    public class UpdateAddressRequest
    {
        public Guid Id { get; set; }
        public string AddressDetail { get; set; }
        public string? CityId { get; set; }
        public string? CountryId { get; set; }
        public string? DistrictId { get; set; }
        public string? NeighborhoodId { get; set; }
    }
}
