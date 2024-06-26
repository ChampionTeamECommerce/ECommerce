﻿using Business.Abstracts;
using Business.DTOs.City.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
      ICityService _cityService;

        public CitiesController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateCityRequest createCityRequest)
        {
            await _cityService.Add(createCityRequest);
            return Ok();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteCityRequest deleteCityRequest)
        {
            await _cityService.Delete(deleteCityRequest);
            return Ok();

        }
        [HttpGet("getList")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _cityService.GetListAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateCityRequest updateCityRequest)
        {
            await _cityService.Update(updateCityRequest);
            return Ok();

        }
    }
}
