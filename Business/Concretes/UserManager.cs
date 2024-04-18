using AutoMapper;
using Business.Abstracts;
using Business.DTOs.User.Request;
using Business.DTOs.User.Response;
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
    public class UserManager : IUserService
    {

        private readonly IUserDal _userDal;
        private readonly IMapper _mapper;
        private readonly IUserOperationClaimDal _userOperationClaimDal;

        public UserManager(IUserDal userDal, IMapper mapper, IUserOperationClaimDal userOperationClaimDal)
        {
            _userDal = userDal;
            _mapper = mapper;
            _userOperationClaimDal = userOperationClaimDal;
        }

        public async Task<IPaginate<GetListUserResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _userDal.GetListAsync(
                         index: pageRequest.PageIndex,
                         size: pageRequest.PageSize);

            var result = _mapper.Map<Paginate<GetListUserResponse>>(data);
            return result;
        }

        public async Task<UpdatedUserResponse> Update(UpdateUserRequest updateUserRequest)
        {

            User? user = await _userDal.GetAsync(u => u.Id == updateUserRequest.Id);
            _mapper.Map(updateUserRequest, user);
            User userUpdated = await _userDal.UpdateAsync(user);
            UpdatedUserResponse updatedUserResponse = _mapper.Map<UpdatedUserResponse>(userUpdated);

            return updatedUserResponse;
        }


        public async Task<UserAuth> Add(UserAuth userAuth)
        {
            User user = _mapper.Map<User>(userAuth);
            User userCreated = await _userDal.AddAsync(user);
            UserAuth userAuthMap = _mapper.Map<UserAuth>(userCreated);
            return userAuthMap;
        }

        public async Task<UserAuth> GetByMail(string email)
        {
            var result = await _userDal.GetAsync(u => u.Email == email);
            UserAuth userAuth = _mapper.Map<UserAuth>(result);
            return userAuth;
        }

        public async Task<DeletedUserResponse> Delete(Guid id)
        {
            User? user = await _userDal.GetAsync(u => u.Id == id);
            await _userDal.DeleteAsync(user);
            DeletedUserResponse deletedUserResponse = _mapper.Map<DeletedUserResponse>(user);
            return deletedUserResponse;
        }





    }
}
