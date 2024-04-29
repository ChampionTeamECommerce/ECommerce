using AutoMapper;
using Business.Abstracts;
using Business.DTOs.User.Request;
using Business.DTOs.User.Response;
using Business.DTOs.UserAddresses.Request;
using Business.DTOs.UserAddresses.Response;
using Business.DTOs.UserOperationClaim.Request;
using Business.DTOs.UserOperationClaim.Response;
using Core.DataAccess.Paging;
using Core.Entity.Concrete;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class UserOperationClaimManager: IUserOperationClaimService
    {
        private readonly IUserOperationClaimDal _userOperationClaimDal;
        private readonly IMapper _mapper;

        public UserOperationClaimManager(IUserOperationClaimDal userOperationClaimDal, IMapper mapper)
        {
            _userOperationClaimDal = userOperationClaimDal;
            _mapper = mapper;
        }

        public async Task<CreatedUserOperationClaimResponse> Add(CreateUserOperationClaimRequest createUserOperationClaimRequest)
        {
            UserOperationClaim userOperationClaim = _mapper.Map<UserOperationClaim>(createUserOperationClaimRequest);
            UserOperationClaim createdUserOperationClaim = await _userOperationClaimDal.AddAsync(userOperationClaim);
            CreatedUserOperationClaimResponse createdUserOperationClaimResponse = _mapper.Map<CreatedUserOperationClaimResponse>(createdUserOperationClaim);

            return createdUserOperationClaimResponse;
        }

        public async Task<DeletedUserOperationClaimResponse> Delete(DeleteUserOperationClaimRequest deleteUserOperationClaimRequest)
        {
            UserOperationClaim? userOperationClaim = await _userOperationClaimDal.GetAsync(u => u.Id == deleteUserOperationClaimRequest.Id);
            await _userOperationClaimDal.DeleteAsync(userOperationClaim);
            DeletedUserOperationClaimResponse deletedUserOperationClaimResponse = _mapper.Map<DeletedUserOperationClaimResponse>(userOperationClaim);
            return deletedUserOperationClaimResponse;
        }

   

        public async Task<IPaginate<GetListUserOperationClaimResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _userOperationClaimDal.GetListAsync(
                        index: pageRequest.PageIndex,
                        size: pageRequest.PageSize);

            var result = _mapper.Map<Paginate<GetListUserOperationClaimResponse>>(data);
            return result;
        }

        public async Task<UpdatedUserOperationClaimResponse> Update(UpdateUserOperationClaimRequest updateUserOperationClaimRequest)
        {
            UserOperationClaim? userOperationClaim = await _userOperationClaimDal.GetAsync(u => u.Id == updateUserOperationClaimRequest.Id);
            _mapper.Map(updateUserOperationClaimRequest, userOperationClaim);
            UserOperationClaim userOperationClaimUpdated = await _userOperationClaimDal.UpdateAsync(userOperationClaim);
            UpdatedUserOperationClaimResponse updatedUserOperationClaimResponse = _mapper.Map<UpdatedUserOperationClaimResponse>(userOperationClaimUpdated);

            return updatedUserOperationClaimResponse;
        }
        public async Task<IList<OperationClaim>> GetClaims(Guid id)
        {
            var userOperationClaims = await _userOperationClaimDal.GetListAsync(u => u.UserId == id,
                                                                   include: u => u.Include(u => u.OperationClaim));
            IList<OperationClaim> operationClaims =
                userOperationClaims.Items.Select(u => new OperationClaim
                { Id = u.OperationClaim.Id, Name = u.OperationClaim.Name }).ToList();
            return operationClaims;
        }
    }
 
}
