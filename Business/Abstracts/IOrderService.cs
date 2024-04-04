using Business.DTOs.Order.Request;
using Business.DTOs.Order.Response;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IOrderService
    {
        Task<IPaginate<GetListOrderResponse>> GetListAsync(PageRequest pageRequest);
        Task<CreatedOrderResponse> Add(CreateOrderRequest createOrderRequest);

        Task<DeletedOrderResponse> Delete(DeleteOrderRequest deleteOrderRequest);
        Task<UpdatedOrderResponse> Update(UpdateOrderRequest updateOrderRequest);
    }
}
