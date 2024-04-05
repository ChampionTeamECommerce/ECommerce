using AutoMapper;
using Business.DTOs.District.Request;
using Business.DTOs.District.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class DistrictMappingProfile :Profile
    {
        public DistrictMappingProfile()
        {
            CreateMap<District, CreateDistrictRequest>().ReverseMap();
            CreateMap<District, CreatedDistrictResponse>().ReverseMap();


            CreateMap<District, UpdateDistrictRequest>().ReverseMap();
            CreateMap<District, UpdatedDistrictResponse>().ReverseMap();

            CreateMap<District, DeleteDistrictRequest>().ReverseMap();
            CreateMap<District, DeletedDistrictResponse>().ReverseMap();

            CreateMap<District, GetListDistrictResponse>().ReverseMap();
            CreateMap<Paginate<District>, Paginate<GetListDistrictResponse>>().ReverseMap();
        }
    }
}
