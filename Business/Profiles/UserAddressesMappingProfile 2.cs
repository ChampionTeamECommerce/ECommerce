using System;
using AutoMapper;
using Business.DTOs.UserAddresses.Request;
using Business.DTOs.UserAddresses.Response;
using Business.DTOs.UserAddresses.Request;
using Business.DTOs.UserAddresses.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class UserAddressesMappingProfile : Profile
    {
        public UserAddressesMappingProfile()
        {
            CreateMap<UserAddresses, CreateUserAddressesRequest>().ReverseMap();
            CreateMap<UserAddresses, CreatedUserAddressesResponse>().ReverseMap();


            CreateMap<UserAddresses, UpdateUserAddressesRequest>().ReverseMap();
            CreateMap<UserAddresses, UpdatedUserAddressesResponse>().ReverseMap();

            CreateMap<UserAddresses, DeleteUserAddressesRequest>().ReverseMap();
            CreateMap<UserAddresses, DeletedUserAddressesResponse>().ReverseMap();

            CreateMap<UserAddresses, GetListUserAddressesResponse>().ReverseMap();
            CreateMap<Paginate<UserAddresses>, Paginate<GetListUserAddressesResponse>>().ReverseMap();
        }

    }
}

