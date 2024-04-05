using Business.Abstracts;
using Business.DTOs.OrderDetail.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        IOrderDetailService _orderDetailService;

        public OrderDetailsController(IOrderDetailService orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateOrderDetailRequest createOrderDetailRequest)
        {
            await _orderDetailService.Add(createOrderDetailRequest);
            return Ok();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteOrderDetailRequest deleteOrderDetailRequest)
        {
            await _orderDetailService.Delete(deleteOrderDetailRequest);
            return Ok();

        }
        [HttpGet("getList")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _orderDetailService.GetListAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateOrderDetailRequest updateOrderDetailRequest)
        {
            await _orderDetailService.Update(updateOrderDetailRequest);
            return Ok();

        }
    }
}
