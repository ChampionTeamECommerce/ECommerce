
using Business.DTOs.Gender.Request;
using Business.DTOs.Gender.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

	public interface IGenderService
	{
    Task<IPaginate<GetListGenderResponse>> GetListAsync(PageRequest pageRequest);
    Task<CreatedGenderResponse> Add(CreateGenderRequest createGenderRequest);

    Task<DeletedGenderResponse> Delete(DeleteGenderRequest deleteGenderRequest);
    Task<UpdatedGenderResponse> Update(UpdateGenderRequest updateGenderRequest);
}

