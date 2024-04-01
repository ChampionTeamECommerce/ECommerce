using AutoMapper;
using Business.Abstracts;
using Business.DTOs.Category.Request;
using Business.DTOs.Category.Response;
using Business.DTOs.Color.Request;
using Business.DTOs.Color.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        IMapper _mapper;

        public ColorManager(IColorDal colorDal, IMapper mapper)
        {
            _colorDal = colorDal;
            _mapper = mapper;
        }

        public async Task<CreatedColorResponse> Add(CreateColorRequest createColorRequest)
        {
            Color color = _mapper.Map<Color>(createColorRequest);
            Color createdColor = await _colorDal.AddAsync(color);
            CreatedColorResponse createdColorResponse = _mapper.Map<CreatedColorResponse>(createdColor);
            return createdColorResponse;
        }

        public async Task<DeletedColorResponse> Delete(DeleteColorRequest deleteColorRequest)
        {
            Color? color = await _colorDal.GetAsync(u => u.Id == deleteColorRequest.Id);
            await _colorDal.DeleteAsync(color);
            DeletedColorResponse deletedColorResponse = _mapper.Map<DeletedColorResponse>(color);
            return deletedColorResponse;
        }

        public async Task<IPaginate<GetListColorResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _colorDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListColorResponse>>(data);
            return result;
        }

        public async Task<UpdatedColorResponse> Update(UpdateColorRequest updateColorRequest)
        {
            Color? color = await _colorDal.GetAsync(u => u.Id == updateColorRequest.Id);
            _mapper.Map(updateColorRequest, color);
            Color updateColor = await _colorDal.UpdateAsync(color);
            UpdatedColorResponse updatedColorResponse = _mapper.Map<UpdatedColorResponse>(updateColor);
            return updatedColorResponse;
        }
    }
}
