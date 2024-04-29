
using Business.DTOs.OperationClaim.Request;
using Business.DTOs.OperationClaim.Response;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IOperationClaimService
    {
        Task<IPaginate<GetListOperationClaimResponse>> GetListAsync(PageRequest pageRequest);
        Task<CreatedOperationClaimResponse> Add(CreateOperationClaimRequest createOperationClaimRequest);

        Task<DeletedOperationClaimResponse> Delete(DeleteOperationClaimRequest deleteOperationClaimRequest);
        Task<UpdatedOperationClaimResponse> Update(UpdateOperationClaimRequest updateOperationClaimRequest);
    }
}
