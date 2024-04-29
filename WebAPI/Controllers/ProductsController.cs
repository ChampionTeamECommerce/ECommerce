using Business.Abstracts;
using Business.DTOs.Product.Request;
using Business.DTOs.Product.Response;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateProductRequest createProductRequest)
        {
            await _productService.Add(createProductRequest);
            return Ok();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteProductRequest deleteProductRequest)
        {
            await _productService.Delete(deleteProductRequest);
            return Ok();

        }
        [HttpGet("getList")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _productService.GetListAsync(pageRequest);
            return Ok(result);
        }
        [HttpGet("{name}")]
        public async Task<IActionResult> GetName([FromRoute] string name) 
        {
            var result = await _productService.GetName(name);
            return Ok(result);
        }


        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateProductRequest updateProductRequest)
        {
            await _productService.Update(updateProductRequest);
            return Ok();

        }
    }
}
