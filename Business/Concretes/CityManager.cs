using AutoMapper;
using Business.Abstracts;
using Business.DTOs.City.Request;
using Business.DTOs.City.Response;

using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concretes;
using Business.DTOs.City.Response;
using Business.Rules;
using Business.DTOs.Color.Request;


namespace Business.Concretes
{

    public class CityManager : ICityService
    {
        ICityDal _cityDal;
        IMapper _mapper;
        CityBusinessRules _cityBusinessRules;

        public CityManager(IMapper mapper, ICityDal cityDal, CityBusinessRules cityBusinessRules)
        {
            _mapper = mapper;
            _cityDal = cityDal;
            _cityBusinessRules = cityBusinessRules;
        }

        public async Task<CreatedCityResponse> Add(CreateCityRequest createCityRequest)
        {
            await _cityBusinessRules.CityCannotBeDuplicated(createCityRequest.Name);
            City city = _mapper.Map<City>(createCityRequest);
            City createdCity = await _cityDal.AddAsync(city);
            CreatedCityResponse createdCityResponse = _mapper.Map<CreatedCityResponse>(createdCity);
            return createdCityResponse;
        }

        public async Task<DeletedCityResponse> Delete(DeleteCityRequest deleteCityRequest)
        {
            City? city = await _cityDal.GetAsync(c => c.Id == deleteCityRequest.Id);
            await _cityDal.DeleteAsync(city);
            DeletedCityResponse deletedCityResponse = _mapper.Map<DeletedCityResponse>(city);
            return deletedCityResponse;
        }

        public async Task<IPaginate<GetListCityResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _cityDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListCityResponse>>(data);
            return result;
        }

        public async Task<UpdatedCityResponse> Update(UpdateCityRequest updateCityRequest)
        {
            City? city = await _cityDal.GetAsync(u => u.Id == updateCityRequest.Id);
            _mapper.Map(updateCityRequest, city);
            City updatecity = await _cityDal.UpdateAsync(city);
            UpdatedCityResponse updatedCityResponse = _mapper.Map<UpdatedCityResponse>(updatecity);
            return updatedCityResponse;
        }
    }
}
