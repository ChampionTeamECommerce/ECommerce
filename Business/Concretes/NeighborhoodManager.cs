using System;
using AutoMapper;
using Business.Abstracts;
using Business.DTOs.Color.Request;
using Business.DTOs.Color.Response;
using Business.DTOs.Gender.Request;
using Business.DTOs.Gender.Response;
using Business.DTOs.Neighborhood.Request;
using Business.DTOs.Neighborhood.Response;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concretes;

public class NeighborhoodManager : INeighborhoodService
{
    INeighborhoodDal _neighborhoodDal;
    IMapper _mapper;
    NeighborhoodBusinessRules _neighborhoodBusinessRules;

    public NeighborhoodManager(INeighborhoodDal neighborhoodDal, IMapper mapper)
    {
        _neighborhoodDal = neighborhoodDal;
        _mapper = mapper;
    }

    public async Task<CreatedNeighborhoodResponse> Add(CreateNeighborhoodRequest createNeighborhoodRequest)
    {

        Neighborhood neighborhood = _mapper.Map<Neighborhood>(createNeighborhoodRequest);
        Neighborhood createdNeighborhood = await _neighborhoodDal.AddAsync(neighborhood);
        CreatedNeighborhoodResponse createdNeighborhoodResponse = _mapper.Map<CreatedNeighborhoodResponse>(createdNeighborhood);

        return createdNeighborhoodResponse;
    }


    public async Task<DeletedNeighborhoodResponse> Delete(DeleteNeighborhoodRequest deleteNeighborhoodRequest)
    {
        Neighborhood neighborhood = await _neighborhoodDal.GetAsync(u => u.Id == deleteNeighborhoodRequest.Id);
        await _neighborhoodDal.DeleteAsync(neighborhood);
        DeletedNeighborhoodResponse deletedNeighborhoodResponse = _mapper.Map<DeletedNeighborhoodResponse>(neighborhood);
        return deletedNeighborhoodResponse;
    }


    public async Task<IPaginate<GetListNeighborhoodResponse>> GetListAsync(PageRequest pageRequest)
    {
        var data = await _neighborhoodDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        var result = _mapper.Map<Paginate<GetListNeighborhoodResponse>>(data);
        return result;
    }

    public async Task<UpdatedNeighborhoodResponse> Update(UpdateNeighborhoodRequest updateNeighborhoodRequest)
    {
        Neighborhood? neighborhood = await _neighborhoodDal.GetAsync(u => u.Id == updateNeighborhoodRequest.Id);
        _mapper.Map(updateNeighborhoodRequest, neighborhood);
        Neighborhood updateNeighborhood = await _neighborhoodDal.UpdateAsync(neighborhood);
        UpdatedNeighborhoodResponse updatedNeighborhoodResponse = _mapper.Map<UpdatedNeighborhoodResponse>(updateNeighborhood);
        return updatedNeighborhoodResponse;
    }

  
}

