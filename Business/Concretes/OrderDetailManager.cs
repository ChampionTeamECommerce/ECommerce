using AutoMapper;
using Business.Abstracts;
using Business.DTOs.OrderDetail.Request;
using Business.DTOs.OrderDetail.Response;
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

    public class OrderDetailManager : IOrderDetailService
    {
        IOrderDetailDal _orderDetailDal;
        IMapper _mapper;

        public OrderDetailManager(IOrderDetailDal orderDetailDal, IMapper mapper)
        {
            _orderDetailDal = orderDetailDal;
            _mapper = mapper;
        }

        public async Task<CreatedOrderDetailResponse> Add(CreateOrderDetailRequest createOrderDetailRequest)
        {
            OrderDetail orderDetail = _mapper.Map<OrderDetail>(createOrderDetailRequest);

            OrderDetail createdOrderDetail = await _orderDetailDal.AddAsync(orderDetail);
            CreatedOrderDetailResponse createdOrderDetailResponse = _mapper.Map<CreatedOrderDetailResponse>(createdOrderDetail);
            return createdOrderDetailResponse;
        }

        public async Task<DeletedOrderDetailResponse> Delete(DeleteOrderDetailRequest deleteOrderDetailRequest)
        {
            OrderDetail? orderDetail = await _orderDetailDal.GetAsync(u => u.Id == deleteOrderDetailRequest.Id);
            await _orderDetailDal.DeleteAsync(orderDetail);
            DeletedOrderDetailResponse deletedOrderDetailResponse = _mapper.Map<DeletedOrderDetailResponse>(orderDetail);
            return deletedOrderDetailResponse;
        }

        public async  Task<IPaginate<GetListOrderDetailResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _orderDetailDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListOrderDetailResponse>>(data);
            return result;
        }

        public async Task<UpdatedOrderDetailResponse> Update(UpdateOrderDetailRequest updateOrderDetailRequest)
        {
            OrderDetail? orderDetail = await _orderDetailDal.GetAsync(u => u.Id == updateOrderDetailRequest.Id);
            _mapper.Map(updateOrderDetailRequest, orderDetail);
            OrderDetail updateOrderDetail = await _orderDetailDal.UpdateAsync(orderDetail);
            UpdatedOrderDetailResponse updatedOrderDetailResponse = _mapper.Map<UpdatedOrderDetailResponse>(updateOrderDetail);
            return updatedOrderDetailResponse;
        }
    }
}
