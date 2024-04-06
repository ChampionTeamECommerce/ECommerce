namespace Business.DTOs.ContactUs.Response
{
    public class CreatedContactUsResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ContactSubjectId { get; set; }
    }
}
