using AutoMapper;
using Business.DTOs.Address.Request;
using Business.DTOs.Address.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class AddressMappingProfile : Profile
    {
        public AddressMappingProfile()
        {
            CreateMap<Address, CreateAddressRequest>().ReverseMap();
            CreateMap<Address, CreatedAddressResponse>().ReverseMap();

            CreateMap<Address, UpdateAddressRequest>().ReverseMap();
            CreateMap<Address, UpdatedAddressResponse>().ReverseMap();

            CreateMap<Address, DeleteAddressRequest>().ReverseMap();
            CreateMap<Address, DeletedAddressResponse>().ReverseMap();

            CreateMap<Address, GetListAddressResponse>()
                .ForMember(destinationMember: a => a.DistrictName,
           memberOptions: opt => opt.MapFrom(a => a.District.Name))
                .ForMember(destinationMember: a => a.CityName,
           memberOptions: opt => opt.MapFrom(a => a.City.Name))
                .ForMember(destinationMember: a => a.CountryName,
           memberOptions: opt => opt.MapFrom(a => a.Country.Name))
                .ForMember(destinationMember: a => a.NeighborhoodName,
           memberOptions: opt => opt.MapFrom(a => a.Neighborhood.Name))
                .ReverseMap();

            CreateMap<Paginate<Address>, Paginate<GetListAddressResponse>>().ReverseMap();
        }
    }
}
