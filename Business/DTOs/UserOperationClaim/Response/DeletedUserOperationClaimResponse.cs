namespace Business.DTOs.UserOperationClaim.Response
{
    public class DeletedUserOperationClaimResponse
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid OperationClaimId { get; set; }
    }
}
