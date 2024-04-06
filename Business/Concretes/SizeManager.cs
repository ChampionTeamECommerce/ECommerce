using System;
using AutoMapper;
using Business.Abstracts;
using Business.DTOs.Address.Request;
using Business.DTOs.Address.Response;
using Business.DTOs.Size.Request;
using Business.DTOs.Size.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
	
        public class SizeManager : ISizeService
    {
            ISizeDal _sizeDal;
            IMapper _mapper;

            public SizeManager(ISizeDal sizeDal, IMapper mapper)
            {
            _sizeDal = sizeDal;
                _mapper = mapper;
            }

            public async Task<CreatedSizeResponse> Add(CreateSizeRequest createSizeRequest)
            {
            Size size = _mapper.Map<Size>(createSizeRequest);
            Size createdSize = await _sizeDal.AddAsync(size);
            CreatedSizeResponse createdSizeResponse = _mapper.Map<CreatedSizeResponse>(createdSize);

                return createdSizeResponse;
            }


        public async Task<DeletedSizeResponse> Delete(DeleteSizeRequest deleteSizeRequest)
            {
            Size size = await _sizeDal.GetAsync(u => u.Id == deleteSizeRequest.Id);
                await _sizeDal.DeleteAsync(size);
            DeletedSizeResponse deletedSizeResponse = _mapper.Map<DeletedSizeResponse>(size);
                return deletedSizeResponse;
            }

      

        public async Task<IPaginate<GetListSizeResponse>> GetListAsync(PageRequest pageRequest)
            {
                var data = await _sizeDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
                var result = _mapper.Map<Paginate<GetListSizeResponse>>(data);

                return result;
            }

            public async Task<UpdatedSizeResponse> Update(UpdateSizeRequest updateSizeRequest)
            {
            Size? size = await _sizeDal.GetAsync(u => u.Id == updateSizeRequest.Id);
                _mapper.Map(updateSizeRequest,size);
            Size updateSize = await _sizeDal.UpdateAsync(size);
            UpdatedSizeResponse updatedSizeResponse = _mapper.Map<UpdatedSizeResponse>(updateSize);
                return updatedSizeResponse;
            }

        
    }
    
}

