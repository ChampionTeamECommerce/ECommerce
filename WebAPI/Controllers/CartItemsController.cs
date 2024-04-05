using Business.Abstracts;
using Business.DTOs.CartItem.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartItemsController : ControllerBase
    {
        ICartItemService _cartItemService;

        public CartItemsController(ICartItemService cartItemService)
        {
            _cartItemService = cartItemService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateCartItemRequest createCartItemRequest)
        {
            await _cartItemService.Add(createCartItemRequest);
            return Ok();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteCartItemRequest deleteCartItemRequest)
        {
            await _cartItemService.Delete(deleteCartItemRequest);
            return Ok();

        }
        [HttpGet("getList")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _cartItemService.GetListAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateCartItemRequest updateCartItemRequest)
        {
            await _cartItemService.Update(updateCartItemRequest);
            return Ok();

        }
    }
}
