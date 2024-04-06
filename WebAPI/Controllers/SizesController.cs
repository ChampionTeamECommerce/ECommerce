using System;
using Business.Abstracts;
using Business.DTOs.Address.Request;
using Business.DTOs.Size.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SizesController : ControllerBase
    {

        ISizeService _sizeService;

        public SizesController(ISizeService sizeService)
        {
            _sizeService = sizeService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateSizeRequest createSizeRequest)
        {
            await _sizeService.Add(createSizeRequest);
            return Ok();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteSizeRequest deleteSizeRequest)
        {
            await _sizeService.Delete(deleteSizeRequest);
            return Ok();

        }
        [HttpGet("getList")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _sizeService.GetListAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateSizeRequest updateSizeRequest)
        {
            await _sizeService.Update(updateSizeRequest);
            return Ok();

        }

    }
}

