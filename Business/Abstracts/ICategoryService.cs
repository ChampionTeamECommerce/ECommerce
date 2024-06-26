﻿using Business.DTOs.Category.Request;
using Business.DTOs.Category.Response;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        Task<IPaginate<GetListCategoryResponse>> GetListAsync(PageRequest pageRequest);
        Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest);

        Task<DeletedCategoryResponse> Delete(DeleteCategoryRequest deleteCategoryRequest);
        Task<UpdatedCategoryResponse> Update(UpdateCategoryRequest updateCategoryRequest);

    }
}
