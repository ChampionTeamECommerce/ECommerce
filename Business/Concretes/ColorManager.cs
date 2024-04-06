using AutoMapper;
using Business.Abstracts;
using Business.DTOs.Category.Request;
using Business.DTOs.Category.Response;
using Business.DTOs.Color.Request;
using Business.DTOs.Color.Response;
using Business.Messages;
using Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
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
        ColorBusinessRules _colorBusinessRules;

        public ColorManager(IColorDal colorDal, IMapper mapper, ColorBusinessRules colorBusinessRules)
        {
            _colorDal = colorDal;
            _mapper = mapper;
            _colorBusinessRules = colorBusinessRules;
        }

        public async Task<CreatedContactUsResponse> Add(CreateContactUsRequest createColorRequest)
        {

            await _colorBusinessRules.ColorCannotBeDuplicated(createColorRequest.Name);


            Color color = _mapper.Map<Color>(createColorRequest);
            Color createdColor = await _colorDal.AddAsync(color);
            CreatedContactUsResponse createdColorResponse = _mapper.Map<CreatedContactUsResponse>(createdColor);
            return createdColorResponse;
        }

        public async Task<DeletedContactUsResponse> Delete(DeleteContactUsRequest deleteColorRequest)
        {
            Color? color = await _colorDal.GetAsync(u => u.Id == deleteColorRequest.Id);
            await _colorDal.DeleteAsync(color);
            DeletedContactUsResponse deletedColorResponse = _mapper.Map<DeletedContactUsResponse>(color);
            return deletedColorResponse;
        }

        public async Task<IPaginate<GetListContactUsResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _colorDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListContactUsResponse>>(data);
            return result;
        }

        public async Task<UpdatedContactUsResponse> Update(UpdateContactUsRequest updateColorRequest)
        {
            Color? color = await _colorDal.GetAsync(u => u.Id == updateColorRequest.Id);
            _mapper.Map(updateColorRequest, color);
            Color updateColor = await _colorDal.UpdateAsync(color);
            UpdatedContactUsResponse updatedColorResponse = _mapper.Map<UpdatedContactUsResponse>(updateColor);
            return updatedColorResponse;
        }

        //public async Task<GetListColorResponse> GetByName(string name)
        //{
        //    var result = await _colorDal.GetAsync(u => u.Name == name);
        //    Color color = _mapper.Map<Color>(result);
        //    return color;
        //}

    }
}
