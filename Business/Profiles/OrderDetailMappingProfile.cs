using AutoMapper;
using Business.DTOs.OrderDetail.Request;
using Business.DTOs.OrderDetail.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class OrderDetailDetailMappingProfile: Profile
    {
        public OrderDetailDetailMappingProfile()
        {
            CreateMap<OrderDetail, CreateOrderDetailRequest>().ReverseMap();
            CreateMap<OrderDetail, CreatedOrderDetailResponse>().ReverseMap();


            CreateMap<OrderDetail, UpdateOrderDetailRequest>().ReverseMap();
            CreateMap<OrderDetail, UpdatedOrderDetailResponse>().ReverseMap();

            CreateMap<OrderDetail, DeleteOrderDetailRequest>().ReverseMap();
            CreateMap<OrderDetail, DeletedOrderDetailResponse>().ReverseMap();

            CreateMap<OrderDetail, GetListOrderDetailResponse>().ReverseMap();
            CreateMap<Paginate<OrderDetail>, Paginate<GetListOrderDetailResponse>>().ReverseMap();
        }
    }
}
