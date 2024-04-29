using AutoMapper;
using Business.DTOs.UserOperationClaim.Request;
using Business.DTOs.UserOperationClaim.Response;
using Core.DataAccess.Paging;
using Core.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class UserOperationClaimProfile : Profile
    {
        public UserOperationClaimProfile()
        {
            CreateMap<UserOperationClaim, CreateUserOperationClaimRequest>().ReverseMap();
            CreateMap<UserOperationClaim, CreatedUserOperationClaimResponse>().ReverseMap();


            CreateMap<UserOperationClaim, UpdateUserOperationClaimRequest>().ReverseMap();
            CreateMap<UserOperationClaim, UpdatedUserOperationClaimResponse>().ReverseMap();

            CreateMap<UserOperationClaim, DeleteUserOperationClaimRequest>().ReverseMap();
            CreateMap<UserOperationClaim, DeletedUserOperationClaimResponse>().ReverseMap();

            CreateMap<UserOperationClaim, GetListUserOperationClaimResponse>().ReverseMap();
            CreateMap<Paginate<UserOperationClaim>, Paginate<GetListUserOperationClaimResponse>>().ReverseMap();
        }
    }
}
