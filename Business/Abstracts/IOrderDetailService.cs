using Business.DTOs.OrderDetail.Request;
using Business.DTOs.OrderDetail.Response;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IOrderDetailService
    {
        Task<IPaginate<GetListOrderDetailResponse>> GetListAsync(PageRequest pageRequest);
        Task<CreatedOrderDetailResponse> Add(CreateOrderDetailRequest createOrderDetailRequest);

        Task<DeletedOrderDetailResponse> Delete(DeleteOrderDetailRequest deleteOrderDetailRequest);
        Task<UpdatedOrderDetailResponse> Update(UpdateOrderDetailRequest updateOrderDetailRequest);
    }
}
