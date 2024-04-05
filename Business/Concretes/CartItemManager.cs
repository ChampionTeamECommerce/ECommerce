using AutoMapper;
using Business.Abstracts;
using Business.DTOs.CartItem.Request;
using Business.DTOs.CartItem.Response;
using Business.DTOs.CartItem.Request;
using Business.DTOs.CartItem.Response;
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

namespace Business.Concretes
{
    public class CartItemManager : ICartItemService
    {
        ICartItemDal _cartItemDal;
        IMapper _mapper;

        public CartItemManager(ICartItemDal cartItemDal, IMapper mapper)
        {
            _cartItemDal = cartItemDal;
            _mapper = mapper;
        }

        public async Task<CreatedCartItemResponse> Add(CreateCartItemRequest createCartItemRequest)
        {
          
            CartItem cartItem = _mapper.Map<CartItem>(createCartItemRequest);
            CartItem createdCartItem = await _cartItemDal.AddAsync(cartItem);
            CreatedCartItemResponse createdCartItemResponse = _mapper.Map<CreatedCartItemResponse>(createdCartItem);
            return createdCartItemResponse;
        }

        public async Task<DeletedCartItemResponse> Delete(DeleteCartItemRequest deleteCartItemRequest)
        {

            CartItem? cartItem = await _cartItemDal.GetAsync(c => c.Id == deleteCartItemRequest.Id);
            await _cartItemDal.DeleteAsync(cartItem);
            DeletedCartItemResponse deletedCartItemResponse = _mapper.Map<DeletedCartItemResponse>(cartItem);
            return deletedCartItemResponse;
        }

        public async Task<IPaginate<GetListCartItemResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _cartItemDal.GetListAsync(
                 include: c => c
                .Include(c => c.Product),
                index: pageRequest.PageIndex, size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListCartItemResponse>>(data);
            return result;
        }

        public async Task<UpdatedCartItemResponse> Update(UpdateCartItemRequest updateCartItemRequest)
        {
            CartItem? cartItem = await _cartItemDal.GetAsync(u => u.Id == updateCartItemRequest.Id);
            _mapper.Map(updateCartItemRequest, cartItem);
            CartItem updatecartItem = await _cartItemDal.UpdateAsync(cartItem);
            UpdatedCartItemResponse updatedCartItemResponse = _mapper.Map<UpdatedCartItemResponse>(updatecartItem);
            return updatedCartItemResponse;
        }
    }
}
