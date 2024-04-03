using Business.DTOs.City.Request;
using Business.DTOs.City.Response;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICityService
    {
        Task<IPaginate<GetListCityResponse>> GetListAsync(PageRequest pageRequest);
        Task<CreatedCityResponse> Add(CreateCityRequest createCityRequest);

        Task<DeletedCityResponse> Delete(DeleteCityRequest deleteCityRequest);
        Task<UpdatedCityResponse> Update(UpdateCityRequest updateCityRequest);
    }
}
