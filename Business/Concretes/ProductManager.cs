using AutoMapper;
using Business.Abstracts;
using Business.DTOs.Product.Request;
using Business.DTOs.Product.Response;
using Business.DTOs.Product.Request;
using Business.DTOs.Product.Response;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Business.DTOs.Address.Response;
using Business.BusinessAspects.Autofac;
using Core.Entity.Concrete;

namespace Business.Concretes
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        IMapper _mapper;
        ProductBusinessRules _productBusinessRules;

        public ProductManager(ProductBusinessRules productBusinessRules, IMapper mapper, IProductDal productDal)
        {
            _productBusinessRules = productBusinessRules;
            _mapper = mapper;
            _productDal = productDal;
        }

       // [SecuredOperation("Product.Add")]
        public async Task<CreatedProductResponse> Add(CreateProductRequest createProductRequest)
        {
            await _productBusinessRules.ProductCannotBeDuplicated(createProductRequest.Name);
            Product product = _mapper.Map<Product>(createProductRequest);
            Product createdProduct = await _productDal.AddAsync(product);
            CreatedProductResponse createdProductResponse = _mapper.Map<CreatedProductResponse>(createdProduct);
            return createdProductResponse;
        }

        public async Task<DeletedProductResponse> Delete(DeleteProductRequest deleteProductRequest)
        {
            Product? product = await _productDal.GetAsync(c => c.Id == deleteProductRequest.Id);
            await _productDal.DeleteAsync(product);
            DeletedProductResponse deletedProductResponse = _mapper.Map<DeletedProductResponse>(product);
            return deletedProductResponse;
        }

        public async Task<IPaginate<GetListProductResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _productDal.GetListAsync(
                include: p => p
                .Include(p => p.Category).
                Include(p => p.Gender).
                Include(p => p.Color).
                Include(p => p.Size),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListProductResponse>>(data);
            return result;

        }

        public async Task<GetListProductResponse> GetName(string name)
        {
            var data = await _productDal.GetAsync(
                p => p.Name.Contains(name),
                include: p => p
                    .Include(p => p.Category)
                    .Include(p => p.Gender)
                    .Include(p => p.Color)
                    .Include(p => p.Size)
            );

            var result = _mapper.Map<GetListProductResponse>(data);
            return result;
        }




        //}
        //public async Task<GetListProductResponse> GetName(string name)
        //{
        //    var data = await _productDal.GetAsync(p => EF.Functions.Like(p.Name, "%" + name + "%"));
        //    var result = _mapper.Map<GetListProductResponse>(data);
        //    return result;
        //}


        public async Task<UpdatedProductResponse> Update(UpdateProductRequest updateProductRequest)
        {
            Product? product = await _productDal.GetAsync(u => u.Id == updateProductRequest.Id);
            _mapper.Map(updateProductRequest, product);
            Product updateproduct = await _productDal.UpdateAsync(product);
            UpdatedProductResponse updatedProductResponse = _mapper.Map<UpdatedProductResponse>(updateproduct);
            return updatedProductResponse;
        }


    }
}
