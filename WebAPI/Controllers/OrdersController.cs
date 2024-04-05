using Business.Abstracts;
using Business.DTOs.Order.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateOrderRequest createOrderRequest)
        {
            await _orderService.Add(createOrderRequest);
            return Ok();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteOrderRequest deleteOrderRequest)
        {
            await _orderService.Delete(deleteOrderRequest);
            return Ok();

        }
        [HttpGet("getList")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _orderService.GetListAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateOrderRequest updateOrderRequest)
        {
            await _orderService.Update(updateOrderRequest);
            return Ok();

        }
    }
}
