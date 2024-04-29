
using Business.DTOs.UserOperationClaim.Request;
using Business.DTOs.UserOperationClaim.Response;
using Core.DataAccess.Paging;
using Core.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IUserOperationClaimService
    {
        Task<IList<OperationClaim>> GetClaims(Guid id);

        Task<IPaginate<GetListUserOperationClaimResponse>> GetListAsync(PageRequest pageRequest);
        Task<CreatedUserOperationClaimResponse> Add(CreateUserOperationClaimRequest createUserOperationClaimRequest);

        Task<DeletedUserOperationClaimResponse> Delete(DeleteUserOperationClaimRequest deleteUserOperationClaimRequest);
        Task<UpdatedUserOperationClaimResponse> Update(UpdateUserOperationClaimRequest updateUserOperationClaimRequest);
    }
}
