using System;
using Business.Abstracts;
using Business.DTOs.Address.Request;
using Business.DTOs.UserAddresses.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAddressesController : ControllerBase
    {

        IUserAddressesService _userAddressesService;

        public UserAddressesController(IUserAddressesService userAddressesService)
        {
            _userAddressesService = userAddressesService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateUserAddressesRequest createUserAddressesRequest)
        {
            await _userAddressesService.Add(createUserAddressesRequest);
            return Ok();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteUserAddressesRequest deleteUserAddressesRequest)
        {
            await _userAddressesService.Delete(deleteUserAddressesRequest);
            return Ok();

        }
        [HttpGet("getList")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _userAddressesService.GetListAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateUserAddressesRequest updateUserAddressesRequest)
        {
            await _userAddressesService.Update(updateUserAddressesRequest);
            return Ok();

        }

    }
}

