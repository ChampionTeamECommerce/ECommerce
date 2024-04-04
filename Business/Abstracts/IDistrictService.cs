using Business.DTOs.District.Request;
using Business.DTOs.District.Response;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IDistrictService
    {
        Task<IPaginate<GetListDistrictResponse>> GetListAsync(PageRequest pageRequest);
        Task<CreatedDistrictResponse> Add(CreateDistrictRequest createDistrictRequest);

        Task<DeletedDistrictResponse> Delete(DeleteDistrictRequest deleteDistrictRequest);
        Task<UpdatedDistrictResponse> Update(UpdateDistrictRequest updateDistrictRequest);
    }
}
