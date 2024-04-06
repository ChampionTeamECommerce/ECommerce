using System;
using AutoMapper;
using Business.Abstracts;
using Business.DTOs.Address.Request;
using Business.DTOs.Address.Response;
using Business.DTOs.UserAddresses.Request;
using Business.DTOs.UserAddresses.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concretes
{
	
        public class UserAddressesManager : IUserAddressesService
        {
            IUserAddressesDal _userAddressesDal;
            IMapper _mapper;

        public async Task<CreatedUserAddressesResponse> Add(CreateUserAddressesRequest createUserAddressesRequest)
        {

            UserAddresses userAddresses = _mapper.Map<UserAddresses>(createUserAddressesRequest);
            UserAddresses createdUserAddresses = await _userAddressesDal.AddAsync(userAddresses);
            CreatedUserAddressesResponse createdUserAddressesResponse = _mapper.Map<CreatedUserAddressesResponse>(createdUserAddresses);

            return createdUserAddressesResponse;
        }

        public async Task<DeletedUserAddressesResponse> Delete(DeleteUserAddressesRequest deleteUserAddressesRequest)
        {
            UserAddresses userAddresses = await _userAddressesDal.GetAsync(u => u.Id == deleteUserAddressesRequest.Id);
            await _userAddressesDal.DeleteAsync(userAddresses);
            DeletedUserAddressesResponse deletedUserAddressesResponse = _mapper.Map<DeletedUserAddressesResponse>(userAddresses);
            return deletedUserAddressesResponse;
        }

        public async Task<IPaginate<GetListUserAddressesResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _userAddressesDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListUserAddressesResponse>>(data);

            return result;
        }

        public async Task<UpdatedUserAddressesResponse> Update(UpdateUserAddressesRequest updateUserAddressesRequest)
        {
            UserAddresses? userAddresses = await _userAddressesDal.GetAsync(u => u.Id == updateUserAddressesRequest.Id);
            _mapper.Map(updateUserAddressesRequest, userAddresses);
            UserAddresses updateUserAddresses = await _userAddressesDal.UpdateAsync(userAddresses);
            UpdatedUserAddressesResponse updatedUserAddressesResponse = _mapper.Map<UpdatedUserAddressesResponse>(updateUserAddresses);
            return updatedUserAddressesResponse;
        }
    }
    
}

