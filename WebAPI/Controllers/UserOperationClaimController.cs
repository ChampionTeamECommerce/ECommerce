using Business.Abstracts;
using Business.DTOs.UserOperationClaim.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserOperationClaimController : ControllerBase
    {
        IUserOperationClaimService _userOperationClaimService;

        public UserOperationClaimController(IUserOperationClaimService userOperationClaimService)
        {
            _userOperationClaimService = userOperationClaimService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateUserOperationClaimRequest createUserOperationClaimRequest)
        {
            await _userOperationClaimService.Add(createUserOperationClaimRequest);
            return Ok();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteUserOperationClaimRequest deleteUserOperationClaimRequest)
        {
            await _userOperationClaimService.Delete(deleteUserOperationClaimRequest);
            return Ok();

        }
        [HttpGet("getList")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _userOperationClaimService.GetListAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateUserOperationClaimRequest updateUserOperationClaimRequest)
        {
            await _userOperationClaimService.Update(updateUserOperationClaimRequest);
            return Ok();

        }
    }
}
