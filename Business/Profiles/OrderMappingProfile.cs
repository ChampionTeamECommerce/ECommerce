using AutoMapper;
using Business.DTOs.Order.Request;
using Business.DTOs.Order.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class OrderMappingProfile: Profile
    {
        public OrderMappingProfile()
        {
            CreateMap<Order, CreateOrderRequest>().ReverseMap();
            CreateMap<Order, CreatedOrderResponse>().ReverseMap();


            CreateMap<Order, UpdateOrderRequest>().ReverseMap();
            CreateMap<Order, UpdatedOrderResponse>().ReverseMap();

            CreateMap<Order, DeleteOrderRequest>().ReverseMap();
            CreateMap<Order, DeletedOrderResponse>().ReverseMap();

            CreateMap<Order, GetListOrderResponse>().ReverseMap();
            CreateMap<Paginate<Order>, Paginate<GetListOrderResponse>>().ReverseMap();
        }
    }
}
