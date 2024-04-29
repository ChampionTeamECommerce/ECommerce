using Business.Abstracts;
using Business.DTOs.OperationClaim.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationClaimController : ControllerBase
    {


        IOperationClaimService _operationClaimService;

        public OperationClaimController(IOperationClaimService operationClaimService)
        {
            _operationClaimService = operationClaimService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateOperationClaimRequest createOperationClaimRequest)
        {
            await _operationClaimService.Add(createOperationClaimRequest);
            return Ok();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteOperationClaimRequest deleteOperationClaimRequest)
        {
            await _operationClaimService.Delete(deleteOperationClaimRequest);
            return Ok();

        }
        [HttpGet("getList")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _operationClaimService.GetListAsync(pageRequest);
            return Ok(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateOperationClaimRequest updateOperationClaimRequest)
        {
            await _operationClaimService.Update(updateOperationClaimRequest);
            return Ok();

        }
    }
}
