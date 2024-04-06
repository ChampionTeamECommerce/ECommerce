using Business.Abstracts;
using Business.DTOs.Color.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        IColorService _colorService;

        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateContactUsRequest createColorRequest)
        {
            await _colorService.Add(createColorRequest);
            return Ok();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteContactUsRequest deleteColorRequest)
        {
            await _colorService.Delete(deleteColorRequest);
            return Ok();

        }
        [HttpGet("getList")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _colorService.GetListAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateContactUsRequest updateColorRequest)
        {
            await _colorService.Update(updateColorRequest);
            return Ok();

        }
    }
}
