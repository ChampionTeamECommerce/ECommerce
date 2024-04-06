using System;
using AutoMapper;
using Business.DTOs.Gender.Request;
using Business.DTOs.Gender.Response;
using Business.DTOs.Neighborhood.Request;
using Business.DTOs.Neighborhood.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class NeighborhoodMappingProfile : Profile
    {
        public NeighborhoodMappingProfile()
        {
            CreateMap<Neighborhood, CreateNeighborhoodRequest>().ReverseMap();
            CreateMap<Neighborhood, CreatedNeighborhoodResponse>().ReverseMap();


            CreateMap<Neighborhood, UpdateNeighborhoodRequest>().ReverseMap();
            CreateMap<Neighborhood, UpdatedNeighborhoodResponse>().ReverseMap();

            CreateMap<Neighborhood, DeleteNeighborhoodRequest>().ReverseMap();
            CreateMap<Neighborhood, DeletedNeighborhoodResponse>().ReverseMap();

            CreateMap<Neighborhood, GetListNeighborhoodResponse>().ReverseMap();
            CreateMap<Paginate<Neighborhood>, Paginate<GetListNeighborhoodResponse>>().ReverseMap();
        }

    }

}

