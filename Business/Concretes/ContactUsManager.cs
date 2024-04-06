using AutoMapper;
using Business.Abstracts;
using Business.DTOs.ContactUs.Request;
using Business.DTOs.ContactUs.Response;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes
{
    public class ContactUsManager : IContactUsService
    {
        IContactUsDal _contactUsDal;
        IMapper _mapper;
        ContactUsBusinessRules _contactUsBusinessRules;

        public ContactUsManager(IContactUsDal contactUsDal, IMapper mapper, ContactUsBusinessRules contactUsBusinessRules)
        {
            _contactUsDal = contactUsDal;
            _mapper = mapper;
            _contactUsBusinessRules = contactUsBusinessRules;
        }

        public async Task<CreatedContactUsResponse> Add(CreateContactUsRequest createContactUsRequest)
        {
            await _contactUsBusinessRules.ContactUsCannotBeDuplicated(createContactUsRequest.Name);


            ContactUs contactUs = _mapper.Map<ContactUs>(createContactUsRequest);
            ContactUs createdContactUs = await _contactUsDal.AddAsync(contactUs);
            CreatedContactUsResponse createdContactUsResponse = _mapper.Map<CreatedContactUsResponse>(createdContactUs);
            return createdContactUsResponse;
        }

        public async Task<DeletedContactUsResponse> Delete(DeleteContactUsRequest deleteContactUsRequest)
        {
            ContactUs? contactUs = await _contactUsDal.GetAsync(u => u.Id == deleteContactUsRequest.Id);
            await _contactUsDal.DeleteAsync(contactUs);
            DeletedContactUsResponse deletedContactUsResponse = _mapper.Map<DeletedContactUsResponse>(contactUs);
            return deletedContactUsResponse;
        }
        public async Task<IPaginate<GetListContactUsResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _contactUsDal.GetListAsync(
                include: p => p
                .Include(p => p.ContactSubject),
                index: pageRequest.PageIndex, size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListContactUsResponse>>(data);
            return result;
        }

        public async Task<UpdatedContactUsResponse> Update(UpdateContactUsRequest updateContactUsRequest)
        {
            ContactUs? contactUs = await _contactUsDal.GetAsync(u => u.Id == updateContactUsRequest.Id);
            _mapper.Map(updateContactUsRequest, contactUs);
            ContactUs updateContactUs = await _contactUsDal.UpdateAsync(contactUs);
            UpdatedContactUsResponse updatedContactUsResponse = _mapper.Map<UpdatedContactUsResponse>(updateContactUs);
            return updatedContactUsResponse;
        }
    }
}
