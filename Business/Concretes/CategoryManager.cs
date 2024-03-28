using AutoMapper;
using Business.Abstracts;
using Business.DTOs.Category.Request;
using Business.DTOs.Category.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        IMapper _mapper;

        public CategoryManager(ICategoryDal categoryDal, IMapper mapper)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
        }

        public async Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest)
        {
            Category category = _mapper.Map<Category>(createCategoryRequest);
            Category createdCategory = await _categoryDal.AddAsync(category);
            CreatedCategoryResponse createdCategoryResponse = _mapper.Map<CreatedCategoryResponse>(createdCategory);

            return createdCategoryResponse;
        }

        public async Task<DeletedCategoryResponse> Delete(DeleteCategoryRequest deleteCategoryRequest)
        {
            Category? category = await _categoryDal.GetAsync(u => u.Id == deleteCategoryRequest.Id);
            await _categoryDal.DeleteAsync(category);
            DeletedCategoryResponse deletedCategoryResponse = _mapper.Map<DeletedCategoryResponse>(category);
            return deletedCategoryResponse;
        }

        public async Task<IPaginate<GetListCategoryResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _categoryDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListCategoryResponse>>(data);

            return result;
        }

        public async Task<UpdatedCategoryResponse> Update(UpdateCategoryRequest updateCategoryRequest)
        {
            Category? category = await _categoryDal.GetAsync(u => u.Id == updateCategoryRequest.Id);
            _mapper.Map(updateCategoryRequest, category);
            Category updateCategory = await _categoryDal.UpdateAsync(category);
            UpdatedCategoryResponse updatedCategoryResponse = _mapper.Map<UpdatedCategoryResponse>(updateCategory);
            return updatedCategoryResponse;
        }
    }
}
