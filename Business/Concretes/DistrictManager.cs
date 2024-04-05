using AutoMapper;
using Business.Abstracts;
using Business.DTOs.Country.Request;
using Business.DTOs.Country.Response;
using Business.DTOs.District.Request;
using Business.DTOs.District.Response;
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
    public class DistrictManager : IDistrictService
    {
        IDistrictDal _districtDal;
        IMapper _mapper;

   
        public DistrictManager(IDistrictDal districtDal, IMapper mapper)
        {
            _districtDal = districtDal;
            _mapper = mapper;
        }


        public async Task<CreatedDistrictResponse> Add(CreateDistrictRequest createDistrictRequest)
        {

            District district = _mapper.Map<District>(createDistrictRequest);

            District createdDistrict = await _districtDal.AddAsync(district);
            CreatedDistrictResponse createdDistrictResponse = _mapper.Map<CreatedDistrictResponse>(createdDistrict);
            return createdDistrictResponse;
        }

        public async Task<DeletedDistrictResponse> Delete(DeleteDistrictRequest deleteDistrictRequest)
        {
            District? district = await _districtDal.GetAsync(u => u.Id == deleteDistrictRequest.Id);
            await _districtDal.DeleteAsync(district);
            DeletedDistrictResponse deletedDistrictResponse = _mapper.Map<DeletedDistrictResponse>(district);
            return deletedDistrictResponse;
        }

        public async Task<IPaginate<GetListDistrictResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _districtDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListDistrictResponse>>(data);
            return result;
        }

        public async Task<UpdatedDistrictResponse> Update(UpdateDistrictRequest updateDistrictRequest)
        {
            District? district = await _districtDal.GetAsync(u => u.Id == updateDistrictRequest.Id);
            _mapper.Map(updateDistrictRequest, district);
            District updateDistrict = await _districtDal.UpdateAsync(district);
            UpdatedDistrictResponse updatedDistrictResponse = _mapper.Map<UpdatedDistrictResponse>(updateDistrict);
            return updatedDistrictResponse;
        }
    }
}
