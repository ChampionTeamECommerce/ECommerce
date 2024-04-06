using AutoMapper;
using Business.DTOs.Color.Request;
using Business.DTOs.Color.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class ColorMappingProfile:Profile
    {
        public ColorMappingProfile()
        {
            CreateMap<Color, CreateContactUsRequest>().ReverseMap();
            CreateMap<Color, CreatedContactUsResponse>().ReverseMap();


            CreateMap<Color, UpdateContactUsRequest>().ReverseMap();
            CreateMap<Color, UpdatedContactUsResponse>().ReverseMap();

            CreateMap<Color, DeleteContactUsRequest>().ReverseMap();
            CreateMap<Color, DeletedContactUsResponse>().ReverseMap();

            CreateMap<Color, GetListContactUsResponse>().ReverseMap();
            CreateMap<Paginate<Color>, Paginate<GetListContactUsResponse>>().ReverseMap();
        }
      
    }
}
