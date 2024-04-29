using AutoMapper;
using Business.DTOs.OperationClaim.Request;
using Business.DTOs.OperationClaim.Response;
using Core.DataAccess.Paging;
using Core.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class OperationClaimProfile : Profile
    {
        public OperationClaimProfile()
        {
            CreateMap<OperationClaim, CreateOperationClaimRequest>().ReverseMap();
            CreateMap<OperationClaim, CreatedOperationClaimResponse>().ReverseMap();


            CreateMap<OperationClaim, UpdateOperationClaimRequest>().ReverseMap();
            CreateMap<OperationClaim, UpdatedOperationClaimResponse>().ReverseMap();

            CreateMap<OperationClaim, DeleteOperationClaimRequest>().ReverseMap();
            CreateMap<OperationClaim, DeletedOperationClaimResponse>().ReverseMap();

            CreateMap<OperationClaim, GetListOperationClaimResponse>().ReverseMap();
            CreateMap<Paginate<OperationClaim>, Paginate<GetListOperationClaimResponse>>().ReverseMap();
        }
    }
}
