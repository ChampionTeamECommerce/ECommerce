using AutoMapper;
using Business.Abstracts;
using Business.DTOs.Order.Request;
using Business.DTOs.Order.Response;
using Business.DTOs.Order.Request;
using Business.DTOs.Order.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;
        IMapper _mapper;

        public OrderManager(IOrderDal orderDal, IMapper mapper)
        {
            _orderDal = orderDal;
            _mapper = mapper;
        }

        public async Task<CreatedOrderResponse> Add(CreateOrderRequest createOrderRequest)
        {

            Order order = _mapper.Map<Order>(createOrderRequest);

            Order createdOrder = await _orderDal.AddAsync(order);
            CreatedOrderResponse createdOrderResponse = _mapper.Map<CreatedOrderResponse>(createdOrder);
            return createdOrderResponse;
        }

        public async Task<DeletedOrderResponse> Delete(DeleteOrderRequest deleteOrderRequest)
        {
            Order? order = await _orderDal.GetAsync(u => u.Id == deleteOrderRequest.Id);
            await _orderDal.DeleteAsync(order);
            DeletedOrderResponse deletedOrderResponse = _mapper.Map<DeletedOrderResponse>(order);
            return deletedOrderResponse;
        }

        public async Task<IPaginate<GetListOrderResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _orderDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListOrderResponse>>(data);
            return result;
        }

        public async Task<UpdatedOrderResponse> Update(UpdateOrderRequest updateOrderRequest)
        {
            Order? order = await _orderDal.GetAsync(u => u.Id == updateOrderRequest.Id);
            _mapper.Map(updateOrderRequest, order);
            Order updateOrder = await _orderDal.UpdateAsync(order);
            UpdatedOrderResponse updatedOrderResponse = _mapper.Map<UpdatedOrderResponse>(updateOrder);
            return updatedOrderResponse;
        }
    }
}
