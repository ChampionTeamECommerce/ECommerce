using Business.Abstracts;
using Business.DTOs.ContactSubject.Request;
using Business.DTOs.ContactSubject.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ContactSubjectsController : ControllerBase
    {
        IContactSubjectService _contactSubjectService;
        public ContactSubjectsController(IContactSubjectService contactSubjectService)
        {
            _contactSubjectService = contactSubjectService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateContactSubjectRequest createContactSubjectRequest)
        {
            await _contactSubjectService.Add(createContactSubjectRequest);
            return Ok();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteContactSubjectRequest deleteContactSubjectRequest)
        {
            await _contactSubjectService.Delete(deleteContactSubjectRequest);
            return Ok();

        }
        [HttpGet("getList")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _contactSubjectService.GetListAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateContactSubjectRequest updateContactSubjectRequest)
        {
            await _contactSubjectService.Update(updateContactSubjectRequest);
            return Ok();

        }



    }



}
        
    

