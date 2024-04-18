using Core.Entity.Concrete;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        Task<AccessToken> CreateToken(UserAuth user, IList<OperationClaim> operationClaims);
    }


}
