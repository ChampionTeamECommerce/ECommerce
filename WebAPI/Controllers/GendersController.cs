using Business.Abstracts;
using Business.DTOs.Gender.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GendersController : ControllerBase
{
    IGenderService _genderService;

    public GendersController(IGenderService genderService)
    {
        _genderService = genderService;
    }

    [HttpPost("add")]
    public async Task<IActionResult> Add([FromBody] CreateGenderRequest createGenderRequest)
    {
        await _genderService.Add(createGenderRequest);
        return Ok();
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> Delete([FromBody] DeleteGenderRequest deleteGenderRequest)
    {
        await _genderService.Delete(deleteGenderRequest);
        return Ok();

    }
    [HttpGet("getList")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _genderService.GetListAsync(pageRequest);
        return Ok(result);
    }
    [HttpPut("update")]
    public async Task<IActionResult> Update([FromBody] UpdateGenderRequest updateGenderRequest)
    {
        await _genderService.Update(updateGenderRequest);
        return Ok();

    }
}

