using AutoMapper;
using Business.Abstracts;
using Business.DTOs.Category.Request;
using Business.DTOs.Category.Response;
using Business.DTOs.OperationClaim.Request;
using Business.DTOs.OperationClaim.Response;
using Business.DTOs.OrderDetail.Request;
using Business.DTOs.OrderDetail.Response;
using Core.DataAccess.Paging;
using Core.Entity.Concrete;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class OperationClaimManager : IOperationClaimService
    {

        IOperationClaimDal _operationClaimDal;
        IMapper _mapper;

        public OperationClaimManager(IOperationClaimDal operationClaimDal, IMapper mapper)
        {
            _operationClaimDal = operationClaimDal;
            _mapper = mapper;
        }

        public async Task<CreatedOperationClaimResponse> Add(CreateOperationClaimRequest createOperationClaimRequest)
        {
            OperationClaim operationClaim = _mapper.Map<OperationClaim>(createOperationClaimRequest);
            OperationClaim createdOperationClaim = await _operationClaimDal.AddAsync(operationClaim);
            CreatedOperationClaimResponse createdOperationClaimResponse = _mapper.Map<CreatedOperationClaimResponse>(createdOperationClaim);

            return createdOperationClaimResponse;
        }

        public async Task<DeletedOperationClaimResponse> Delete(DeleteOperationClaimRequest deleteOperationClaimRequest)
        {
            OperationClaim? operationClaim = await _operationClaimDal.GetAsync(u => u.Id == deleteOperationClaimRequest.Id);
            await _operationClaimDal.DeleteAsync(operationClaim);
            DeletedOperationClaimResponse deletedOperationClaimResponse = _mapper.Map<DeletedOperationClaimResponse>(operationClaim);
            return deletedOperationClaimResponse;
        }

        public async Task<IPaginate<GetListOperationClaimResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _operationClaimDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListOperationClaimResponse>>(data);

            return result;
        }

        public async Task<UpdatedOperationClaimResponse> Update(UpdateOperationClaimRequest updateOperationClaimRequest)
        {
            OperationClaim? operationClaim = await _operationClaimDal.GetAsync(u => u.Id == updateOperationClaimRequest.Id);
            _mapper.Map(updateOperationClaimRequest, operationClaim);
            OperationClaim updateOperationClaim = await _operationClaimDal.UpdateAsync(operationClaim);
            UpdatedOperationClaimResponse updatedOperationClaimResponse = _mapper.Map<UpdatedOperationClaimResponse>(updateOperationClaim);
            return updatedOperationClaimResponse;

        }
    }
}
