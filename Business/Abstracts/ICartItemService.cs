using Business.DTOs.CartItem.Request;
using Business.DTOs.CartItem.Response;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICartItemService
    {
        Task<IPaginate<GetListCartItemResponse>> GetListAsync(PageRequest pageRequest);
        Task<CreatedCartItemResponse> Add(CreateCartItemRequest createCartItemRequest);

        Task<DeletedCartItemResponse> Delete(DeleteCartItemRequest deleteCartItemRequest);
        Task<UpdatedCartItemResponse> Update(UpdateCartItemRequest updateCartItemRequest);
    }
}
