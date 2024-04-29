using System;
using Business.DTOs.Address.Request;
using Business.DTOs.Address.Response;
using Business.DTOs.Size.Request;
using Business.DTOs.Size.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
	public interface ISizeService
	{
        Task<IPaginate<GetListSizeResponse>> GetListAsync(PageRequest pageRequest);
        Task<CreatedSizeResponse> Add(CreateSizeRequest createSizeRequest);

        Task<DeletedSizeResponse> Delete(DeleteSizeRequest deleteSizeRequest);
        Task<UpdatedSizeResponse> Update(UpdateSizeRequest updateSizeRequest);
        Task<GetListSizeResponse> GetName(string name);
    }
}

