using System;
using AutoMapper;
using Business.Abstracts;
using Business.DTOs.Address.Request;
using Business.DTOs.Address.Response;
using Business.DTOs.Gender.Request;
using Business.DTOs.Gender.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
	public class GenderManager:IGenderService
	{
        IGenderDal _genderDal;
        IMapper _mapper;

        public GenderManager(IGenderDal genderDal, IMapper mapper)
        {
            _genderDal = genderDal;
            _mapper = mapper;
        }

        public async Task<CreatedGenderResponse> Add(CreateGenderRequest createGenderRequest)
        {
            Gender gender = _mapper.Map<Gender>(createGenderRequest);
            Gender createdGender = await _genderDal.AddAsync(gender);
            CreatedGenderResponse createdGenderResponse = _mapper.Map<CreatedGenderResponse>(createdGender);

            return createdGenderResponse;
        }

        public async Task<DeletedGenderResponse> Delete(DeleteGenderRequest deleteGenderRequest)
        {
            Gender gender = await _genderDal.GetAsync(u => u.Id == deleteGenderRequest.Id);
            await _genderDal.DeleteAsync(gender);
            DeletedGenderResponse deletedGenderResponse = _mapper.Map<DeletedGenderResponse>(gender);
            return deletedGenderResponse;
        }

        public async Task<IPaginate<GetListGenderResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _genderDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListGenderResponse>>(data);

            return result;
        }

        public async Task<UpdatedGenderResponse> Update(UpdateGenderRequest updateGenderRequest)
        {
            Gender? gender = await _genderDal.GetAsync(u => u.Id == updateGenderRequest.Id);
            _mapper.Map(updateGenderRequest, gender);
            Gender updateGender = await _genderDal.UpdateAsync(gender);
            UpdatedGenderResponse updatedGenderResponse = _mapper.Map<UpdatedGenderResponse>(updateGender);
            return updatedGenderResponse;
        }
    }
}

