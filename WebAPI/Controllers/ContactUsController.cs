using Business.Abstracts;
using Business.DTOs.ContactUs.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsController : ControllerBase
    {

        IContactUsService _contactUsService;

        public ContactUsController(IContactUsService contactUsService)
        {
            _contactUsService = contactUsService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateContactUsRequest createContactUsRequest)
        {
            await _contactUsService.Add(createContactUsRequest);
            return Ok();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteContactUsRequest deleteContactUsRequest)
        {
            await _contactUsService.Delete(deleteContactUsRequest);
            return Ok();

        }
        [HttpGet("getList")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _contactUsService.GetListAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateContactUsRequest updateContactUsRequest)
        {
            await _contactUsService.Update(updateContactUsRequest);
            return Ok();

        }
    }
}
