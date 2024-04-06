namespace Business.DTOs.ContactUs.Request
{
    public class UpdateContactUsRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ContactSubjectId { get; set; }
    }
}
