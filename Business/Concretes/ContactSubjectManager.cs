using AutoMapper;
using Business.Abstracts;
using Business.DTOs.ContactSubject.Request;
using Business.DTOs.ContactSubject.Response;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ContactSubjectManager : IContactSubjectService
    {
         
        IContactSubjectDal _contactSubjectDal;
        IMapper _mapper;

        public ContactSubjectManager(IContactSubjectDal contactSubjectDal, IMapper mapper)
        {
            _contactSubjectDal = contactSubjectDal;
            _mapper = mapper;
        }

        public async Task<CreatedContactSubjectResponse> Add(CreateContactSubjectRequest createContactSubjectRequest)
        {
            ContactSubject contactSubject = _mapper.Map<ContactSubject>(createContactSubjectRequest);

            ContactSubject createdContactSubject = await _contactSubjectDal.AddAsync(contactSubject);
            CreatedContactSubjectResponse createdContactSubjectResponse = _mapper.Map<CreatedContactSubjectResponse>(createdContactSubject);
            return createdContactSubjectResponse;
        }

         public async Task<DeletedContactSubjectResponse> Delete(DeleteContactSubjectRequest deleteContactSubjectRequest)
        {
            ContactSubject? contactSubject = await _contactSubjectDal.GetAsync(u => u.Id == deleteContactSubjectRequest.Id);
            await _contactSubjectDal.DeleteAsync(contactSubject);
            DeletedContactSubjectResponse deletedContactSubjectResponse = _mapper.Map<DeletedContactSubjectResponse>(contactSubject);
            return deletedContactSubjectResponse;
        }

         public async Task<IPaginate<GetListContactSubjectResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _contactSubjectDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListContactSubjectResponse>>(data);
            return result;
        }

         public async Task<UpdatedContactSubjectResponse> Update(UpdateContactSubjectRequest updateContactSubjectRequest)
        {
            ContactSubject? contactSubject = await _contactSubjectDal.GetAsync(u => u.Id == updateContactSubjectRequest.Id);
            _mapper.Map(updateContactSubjectRequest, contactSubject);
            ContactSubject updateContactSubject = await _contactSubjectDal.UpdateAsync(contactSubject);
            UpdatedContactSubjectResponse updatedContactSubjectResponse = _mapper.Map<UpdatedContactSubjectResponse>(updateContactSubject);
            return updatedContactSubjectResponse;
        }

        
    }
}
    

