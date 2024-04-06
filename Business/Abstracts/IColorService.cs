
using Business.DTOs.Color.Request;
using Business.DTOs.Color.Response;
using Core.DataAccess.Paging;


namespace Business.Abstracts
{
    public interface IColorService
    {
        Task<IPaginate<GetListColorResponse>> GetListAsync(PageRequest pageRequest);
        Task<CreatedColorResponse> Add(CreateColorRequest createColorRequest);

        Task<DeletedColorResponse> Delete(DeleteColorRequest deleteColorRequest);
        Task<UpdatedColorResponse> Update(UpdateColorRequest updateColorRequest);

        //Task<GetListColorResponse> GetByName(string Name);
    }
}
