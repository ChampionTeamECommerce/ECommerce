﻿using Business.DTOs.Country.Request;
using Business.DTOs.Country.Response;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICountryService
    {
        Task<IPaginate<GetListCountryResponse>> GetListAsync(PageRequest pageRequest);
        Task<CreatedCountryResponse> Add(CreateCountryRequest createCountryRequest);

        Task<DeletedCountryResponse> Delete(DeleteCountryRequest deleteCountryRequest);
        Task<UpdatedCountryResponse> Update(UpdateCountryRequest updateCountryRequest);
    }
}
