using AutoMapper;
using Business.DTOs.City.Request;
using Business.DTOs.City.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CityMappingProfile : Profile
    {
        public CityMappingProfile()
        {
            CreateMap<City, CreateCityRequest>().ReverseMap();
            CreateMap<City, CreatedCityResponse>().ReverseMap();

            CreateMap<City, UpdateCityRequest>().ReverseMap();
            CreateMap<City, UpdatedCityResponse>().ReverseMap();

            CreateMap<City, DeleteCityRequest>().ReverseMap();
            CreateMap<City, DeletedCityResponse>().ReverseMap();

            CreateMap<City, GetListCityResponse>()
                .ForMember(destinationMember: c => c.CountryName,
           memberOptions: opt => opt.MapFrom(c => c.Country.Name));
         
            CreateMap<Paginate<City>, Paginate<GetListCityResponse>>().ReverseMap();
        }
    }
}
