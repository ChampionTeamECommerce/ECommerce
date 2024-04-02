
using Business.DTOs.Address.Request;
using Business.DTOs.Address.Response;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IAddressService
    {
        Task<IPaginate<GetListAddressResponse>> GetListAsync(PageRequest pageRequest);
        Task<CreatedAddressResponse> Add(CreateAddressRequest createAddressRequest);

        Task<DeletedAddressResponse> Delete(DeleteAddressRequest deleteAddressRequest);
        Task<UpdatedAddressResponse> Update(UpdateAddressRequest updateAddressRequest);
    }
}
