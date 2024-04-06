using System;
using Business.DTOs.Color.Request;
using Business.DTOs.Color.Response;
using Business.DTOs.Neighborhood.Request;
using Business.DTOs.Neighborhood.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
	public interface INeighborhoodService
	{

        Task<IPaginate<GetListNeighborhoodResponse>> GetListAsync(PageRequest pageRequest);
        Task<CreatedNeighborhoodResponse> Add(CreateNeighborhoodRequest createNeighborhoodRequest);

        Task<DeletedNeighborhoodResponse> Delete(DeleteNeighborhoodRequest deleteNeighborhoodRequest);
        Task<UpdatedNeighborhoodResponse> Update(UpdateNeighborhoodRequest updateNeighborhoodRequest);
    }
}

