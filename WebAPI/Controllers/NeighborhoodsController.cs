using System;
using Business.Abstracts;
using Business.DTOs.Color.Request;
using Business.DTOs.Neighborhood.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NeighborhoodsController : ControllerBase
    {
        INeighborhoodService _neighborhoodService;

        public NeighborhoodsController(INeighborhoodService neighborhoodService)
        {
            _neighborhoodService = neighborhoodService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateNeighborhoodRequest createNeighborhoodRequest)
        {
            await _neighborhoodService.Add(createNeighborhoodRequest);
            return Ok();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteNeighborhoodRequest deleteNeighborhoodRequest)
        {
            await _neighborhoodService.Delete(deleteNeighborhoodRequest);
            return Ok();

        }
        [HttpGet("getList")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _neighborhoodService.GetListAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateNeighborhoodRequest updateNeighborhoodRequest)
        {
            await _neighborhoodService.Update(updateNeighborhoodRequest);
            return Ok();

        }
    }
}

