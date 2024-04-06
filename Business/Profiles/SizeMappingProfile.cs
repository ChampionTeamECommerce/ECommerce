using System;
using AutoMapper;
using Business.DTOs.Color.Request;
using Business.DTOs.Color.Response;
using Business.DTOs.Size.Request;
using Business.DTOs.Size.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class SizeMappingProfile : Profile
    {
        public SizeMappingProfile()
        {
            CreateMap<Size, CreateSizeRequest>().ReverseMap();
            CreateMap<Size, CreatedSizeResponse>().ReverseMap();


            CreateMap<Size, UpdateSizeRequest>().ReverseMap();
            CreateMap<Size, UpdatedSizeResponse>().ReverseMap();

            CreateMap<Size, DeleteSizeRequest>().ReverseMap();
            CreateMap<Size, DeletedSizeResponse>().ReverseMap();

            CreateMap<Size, GetListSizeResponse>().ReverseMap();
            CreateMap<Paginate<Size>, Paginate<GetListSizeResponse>>().ReverseMap();
        }

    }
}

