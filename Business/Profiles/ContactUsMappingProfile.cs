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
    public class ContactUsMappingProfile : Profile
    {
        public ContactUsMappingProfile()
        {
            CreateMap<ContactUs, CreateContactUsRequest>().ReverseMap();
            CreateMap<ContactUs, CreatedContactUsResponse>().ReverseMap();


            CreateMap<ContactUs, UpdateContactUsRequest>().ReverseMap();
            CreateMap<ContactUs, UpdatedContactUsResponse>().ReverseMap();

            CreateMap<ContactUs, DeleteContactUsRequest>().ReverseMap();
            CreateMap<ContactUs, DeletedContactUsResponse>().ReverseMap();

            CreateMap<ContactUs, GetListContactUsResponse>().ReverseMap();
            CreateMap<Paginate<ContactUs>, Paginate<GetListContactUsResponse>>().ReverseMap();
        }
    }
}
