using AutoMapper;
using Business.Abstracts;
using Business.DTOs.Country.Request;
using Business.DTOs.Country.Response;
using Business.DTOs.Country.Request;
using Business.DTOs.Country.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concretes;
using Business.DTOs.Country.Response;
using Business.DTOs.Country.Request;

namespace Business.Concretes
{

    public class CountryManager : ICountryService
    {
        ICountryDal _countryDal; 
        IMapper _mapper;

        public CountryManager(IMapper mapper, ICountryDal countryDal)
        {
            _mapper = mapper;
            _countryDal = countryDal;
        }
        public async Task<CreatedCountryResponse> Add(CreateCountryRequest createCountryRequest)
        {
            Country country = _mapper.Map<Country>(createCountryRequest);

            Country createdCountry = await _countryDal.AddAsync(country);
            CreatedCountryResponse createdCountryResponse = _mapper.Map<CreatedCountryResponse>(createdCountry);
            return createdCountryResponse;
        }

        public async Task<DeletedCountryResponse> Delete(DeleteCountryRequest deleteCountryRequest)
        {
            Country? country = await _countryDal.GetAsync(u => u.Id == deleteCountryRequest.Id);
            await _countryDal.DeleteAsync(country);
            DeletedCountryResponse deletedCountryResponse = _mapper.Map<DeletedCountryResponse>(country);
            return deletedCountryResponse;
        }

        public async Task<IPaginate<GetListCountryResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _countryDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListCountryResponse>>(data);
            return result;
        }

        public async Task<UpdatedCountryResponse> Update(UpdateCountryRequest updateCountryRequest)
        {
            Country? country = await _countryDal.GetAsync(u => u.Id == updateCountryRequest.Id);
            _mapper.Map(updateCountryRequest, country);
            Country updateCountry = await _countryDal.UpdateAsync(country);
            UpdatedCountryResponse updatedCountryResponse = _mapper.Map<UpdatedCountryResponse>(updateCountry);
            return updatedCountryResponse;
        }
    }
}
