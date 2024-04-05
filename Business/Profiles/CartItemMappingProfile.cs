using AutoMapper;
using Business.DTOs.CartItem.Request;
using Business.DTOs.CartItem.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CartItemMappingProfile : Profile
    {
        public CartItemMappingProfile()
        {
            CreateMap<CartItem, CreateCartItemRequest>().ReverseMap();
            CreateMap<CartItem, CreatedCartItemResponse>().ReverseMap();

            CreateMap<CartItem, UpdateCartItemRequest>().ReverseMap();
            CreateMap<CartItem, UpdatedCartItemResponse>().ReverseMap();

            CreateMap<CartItem, DeleteCartItemRequest>().ReverseMap();
            CreateMap<CartItem, DeletedCartItemResponse>().ReverseMap();

            CreateMap<CartItem, GetListCartItemResponse>()
                .ForMember(destinationMember: c => c.ProductName,
           memberOptions: opt => opt.MapFrom(c => c.Product.Name));

            CreateMap<Paginate<CartItem>, Paginate<GetListCartItemResponse>>().ReverseMap();
        }
    }
}
