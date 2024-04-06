using AutoMapper;
using Business.DTOs.ContactUs.Request;
using Business.DTOs.ContactUs.Response;
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

            CreateMap<ContactUs, GetListContactUsResponse>()
                .ForMember(destinationMember: a => a.Name,
           memberOptions: opt => opt.MapFrom(a => a.ContactSubject.Name))
                .ForMember(destinationMember: a => a.ContactSubjectId,
           memberOptions: opt => opt.MapFrom(a => a.ContactSubject.Id))
                .ReverseMap();
            CreateMap<Paginate<ContactUs>, Paginate<GetListContactUsResponse>>().ReverseMap();
        }
    }
}
