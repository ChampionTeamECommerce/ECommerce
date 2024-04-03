using Business.DTOs.Product.Request;
using Business.DTOs.Product.Response;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IProductService
    {
        Task<IPaginate<GetListProductResponse>> GetListAsync(PageRequest pageRequest);
        Task<CreatedProductResponse> Add(CreateProductRequest createProductRequest);

        Task<DeletedProductResponse> Delete(DeleteProductRequest deleteProductRequest);
        Task<UpdatedProductResponse> Update(UpdateProductRequest updateProductRequest);
    }
}
