
using Business.DTOs.Color.Request;
using Business.DTOs.Color.Response;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
