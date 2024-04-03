namespace Business.DTOs.City.Response
{
    public class DeletedCityResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? CountryId { get; set; }
    }
}
