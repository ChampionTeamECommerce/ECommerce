using Business.DTOs.ContactUs.Request;
using Business.DTOs.ContactUs.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IContactUsService
    {
        Task<IPaginate<GetListContactUsResponse>> GetListAsync(PageRequest pageRequest);
        Task<CreatedContactUsResponse> Add(CreateContactUsRequest createContactUsRequest);

        Task<DeletedContactUsResponse> Delete(DeleteContactUsRequest deleteContactUsRequest);
        Task<UpdatedContactUsResponse> Update(UpdateContactUsRequest updateContactUsRequest);
    }
}
