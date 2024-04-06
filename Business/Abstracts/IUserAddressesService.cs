using System;
using Business.DTOs.Address.Request;
using Business.DTOs.Address.Response;
using Business.DTOs.UserAddresses.Request;
using Business.DTOs.UserAddresses.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
	public interface IUserAddressesService
	{
        Task<IPaginate<GetListUserAddressesResponse>> GetListAsync(PageRequest pageRequest);
        Task<CreatedUserAddressesResponse> Add(CreateUserAddressesRequest createUserAddressesRequest);

        Task<DeletedUserAddressesResponse> Delete(DeleteUserAddressesRequest deleteUserAddressesRequest);
        Task<UpdatedUserAddressesResponse> Update(UpdateUserAddressesRequest updateUserAddressesRequest);
    }
}

