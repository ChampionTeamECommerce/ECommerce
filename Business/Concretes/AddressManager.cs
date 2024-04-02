using AutoMapper;
using Business.Abstracts;

using Business.DTOs.Address.Request;
using Business.DTOs.Address.Response;
using Business.DTOs.Address.Response;
using Business.DTOs.Address.Request;
using Business.DTOs.Address.Response;
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
    public class AddressManager : IAddressService
    {
        IAddressDal _addressDal;
        IMapper _mapper;

        public AddressManager(IAddressDal addressDal, IMapper mapper)
        {
            _addressDal = addressDal;
            _mapper = mapper;
        }

        public async Task<CreatedAddressResponse> Add(CreateAddressRequest createAddressRequest)
        {
            Address address = _mapper.Map<Address>(createAddressRequest);
            Address createdAddress = await _addressDal.AddAsync(address);
            CreatedAddressResponse createdAddressResponse = _mapper.Map<CreatedAddressResponse>(createdAddress);

            return createdAddressResponse;
        }

        public async Task<DeletedAddressResponse> Delete(DeleteAddressRequest deleteAddressRequest)
        {
            Address address = await _addressDal.GetAsync(u => u.Id == deleteAddressRequest.Id);
            await _addressDal.DeleteAsync(address);
            DeletedAddressResponse deletedAddressResponse = _mapper.Map<DeletedAddressResponse>(address);
            return deletedAddressResponse;
        }

        public async Task<IPaginate<GetListAddressResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _addressDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListAddressResponse>>(data);

            return result;
        }

        public async Task<UpdatedAddressResponse> Update(UpdateAddressRequest updateAddressRequest)
        {
           Address? address = await _addressDal.GetAsync(u => u.Id == updateAddressRequest.Id);
            _mapper.Map(updateAddressRequest,address);
           Address updateAddress = await _addressDal.UpdateAsync(address);
            UpdatedAddressResponse updatedAddressResponse = _mapper.Map<UpdatedAddressResponse>(updateAddress);
            return updatedAddressResponse;
        }
    }
}
