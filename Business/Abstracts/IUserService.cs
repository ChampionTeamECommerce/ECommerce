
using Business.DTOs.CartItem.Response;
using Business.DTOs.User.Request;
using Business.DTOs.User.Response;
using Core.DataAccess.Paging;
using Core.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IUserService
    {
        Task<IPaginate<GetListUserResponse>> GetListAsync(PageRequest pageRequest);
        Task<UserAuth> Add(UserAuth userAuth);
        Task<UpdatedUserResponse> Update(UpdateUserRequest updateUserRequest);
        Task<DeletedUserResponse> Delete(Guid id);
        Task<UserAuth> GetByMail(string email);
        //Task<UserAuth> Add(UserAuth userAuth);
        //Task<UpdatedUserResponse> Update(UpdateUserRequest updateUserRequest);
        //Task<DeletedUserResponse> Delete(DeleteUserRequest deleteUserRequest);
        //Task<IPaginate<GetListUserResponse>> GetListAsync(PageRequest pageRequest);
        //Task<UserAuth> GetByMail(string email);

    }
}
