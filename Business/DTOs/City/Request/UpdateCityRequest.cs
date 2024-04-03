namespace Business.DTOs.City.Request
{
    public class UpdateCityRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? CountryId { get; set; }
    }
}
