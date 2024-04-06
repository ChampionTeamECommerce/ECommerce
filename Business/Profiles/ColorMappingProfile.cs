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
            CreateMap<Color, CreateColorRequest>().ReverseMap();
            CreateMap<Color, CreatedColorResponse>().ReverseMap();


            CreateMap<Color, UpdateColorRequest>().ReverseMap();
            CreateMap<Color, UpdatedColorResponse>().ReverseMap();

            CreateMap<Color, DeleteColorRequest>().ReverseMap();
            CreateMap<Color, DeletedColorResponse>().ReverseMap();

            CreateMap<Color, GetListColorResponse>().ReverseMap();
            CreateMap<Paginate<Color>, Paginate<GetListColorResponse>>().ReverseMap();
        }
      
    }
}
