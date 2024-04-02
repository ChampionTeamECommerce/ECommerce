using Business.Abstracts;
using Business.DTOs.Address.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {

        IAddressService _addressService;

        public AddressesController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateAddressRequest createAddressRequest)
        {
            await _addressService.Add(createAddressRequest);
            return Ok();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteAddressRequest deleteAddressRequest)
        {
            await _addressService.Delete(deleteAddressRequest);
            return Ok();

        }
        [HttpGet("getList")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _addressService.GetListAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateAddressRequest updateAddressRequest)
        {
            await _addressService.Update(updateAddressRequest);
            return Ok();

        }

    }
}
