using AutoMapper;
using Business.DTOs.ContactSubject.Request;
using Business.DTOs.ContactSubject.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class ContactSubjectMappingProfile : Profile
    {
        public ContactSubjectMappingProfile()
        {
            CreateMap<ContactSubject, CreateContactSubjectRequest>().ReverseMap();
            CreateMap<ContactSubject, CreatedContactSubjectResponse>().ReverseMap();


            CreateMap<ContactSubject, UpdateContactSubjectRequest>().ReverseMap();
            CreateMap<ContactSubject, UpdatedContactSubjectResponse>().ReverseMap();

            CreateMap<ContactSubject, DeleteContactSubjectRequest>().ReverseMap();
            CreateMap<ContactSubject, DeletedContactSubjectResponse>().ReverseMap();

            CreateMap<ContactSubject, GetListContactSubjectResponse>().ReverseMap();
            CreateMap<Paginate<ContactSubject>, Paginate<GetListContactSubjectResponse>>().ReverseMap();
        }
    }
}
