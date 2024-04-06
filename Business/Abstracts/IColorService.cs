
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
        Task<IPaginate<GetListContactUsResponse>> GetListAsync(PageRequest pageRequest);
        Task<CreatedContactUsResponse> Add(CreateContactUsRequest createColorRequest);

        Task<DeletedContactUsResponse> Delete(DeleteContactUsRequest deleteColorRequest);
        Task<UpdatedContactUsResponse> Update(UpdateContactUsRequest updateColorRequest);

        //Task<GetListColorResponse> GetByName(string Name);
    }
}
