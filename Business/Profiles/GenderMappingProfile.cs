using System;
using AutoMapper;
using Business.DTOs.Color.Request;
using Business.DTOs.Color.Response;
using Business.DTOs.Gender.Request;
using Business.DTOs.Gender.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class GenderMappingProfile : Profile
{
    public GenderMappingProfile()
    {
        CreateMap<Gender, CreateGenderRequest>().ReverseMap();
        CreateMap<Gender, CreatedGenderResponse>().ReverseMap();


        CreateMap<Gender, UpdateGenderRequest>().ReverseMap();
        CreateMap<Gender, UpdatedGenderResponse>().ReverseMap();

        CreateMap<Gender, DeleteGenderRequest>().ReverseMap();
        CreateMap<Gender, DeletedGenderResponse>().ReverseMap();

        CreateMap<Gender, GetListGenderResponse>().ReverseMap();
        CreateMap<Paginate<Gender>, Paginate<GetListGenderResponse>>().ReverseMap();
    }

}

