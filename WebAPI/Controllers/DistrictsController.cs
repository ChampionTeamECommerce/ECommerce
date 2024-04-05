using Business.Abstracts;
using Business.DTOs.District.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictsController : ControllerBase
    {
        IDistrictService _districtService;

        public DistrictsController(IDistrictService districtService)
        {
            _districtService = districtService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateDistrictRequest createDistrictRequest)
        {
            await _districtService.Add(createDistrictRequest);
            return Ok();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteDistrictRequest deleteDistrictRequest)
        {
            await _districtService.Delete(deleteDistrictRequest);
            return Ok();

        }
        [HttpGet("getList")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _districtService.GetListAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateDistrictRequest updateDistrictRequest)
        {
            await _districtService.Update(updateDistrictRequest);
            return Ok();

        }
    }
}
