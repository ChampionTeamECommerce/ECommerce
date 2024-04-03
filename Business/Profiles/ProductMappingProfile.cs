using AutoMapper;
using Business.DTOs.Product.Request;
using Business.DTOs.Product.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {

            CreateMap<Product, CreateProductRequest>().ReverseMap();
            CreateMap<Product, CreatedProductResponse>().ReverseMap();

            CreateMap<Product, UpdateProductRequest>().ReverseMap();
            CreateMap<Product, UpdatedProductResponse>().ReverseMap();

            CreateMap<Product, DeleteProductRequest>().ReverseMap();
            CreateMap<Product, DeletedProductResponse>().ReverseMap();

            CreateMap<Product, GetListProductResponse>()
                .ForMember(destinationMember: a => a.CategoryName,
           memberOptions: opt => opt.MapFrom(a => a.Category.Name))
                .ForMember(destinationMember: a => a.GenderName,
           memberOptions: opt => opt.MapFrom(a => a.Gender.Name))
                .ForMember(destinationMember: a => a.SizeName,
           memberOptions: opt => opt.MapFrom(a => a.Size.Name))
                .ForMember(destinationMember: a => a.ColorName,
           memberOptions: opt => opt.MapFrom(a => a.Color.Name))
                .ReverseMap();
            CreateMap<Paginate<Product>, Paginate<GetListProductResponse>>().ReverseMap();
        }
    }
}
