namespace Business.DTOs.City.Response
{
    public class GetListCityResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? CountryName { get; set; }
    }
}
