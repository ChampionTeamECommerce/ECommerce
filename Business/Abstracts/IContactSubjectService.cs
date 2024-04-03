using Business.DTOs.Color.Request;
using Business.DTOs.Color.Response;
using Business.DTOs.ContactSubject.Request;
using Business.DTOs.ContactSubject.Response;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IContactSubjectService
    {
        Task<IPaginate<GetListContactSubjectResponse>> GetListAsync(PageRequest pageRequest);
        Task<CreatedContactSubjectResponse> Add(CreateContactSubjectRequest createContactSubjectRequest);

        Task<DeletedContactSubjectResponse> Delete(DeleteContactSubjectRequest deleteContactSubjectRequest);
        Task<UpdatedContactSubjectResponse> Update(UpdateContactSubjectRequest updateContactSubjectRequest);
    }
}
