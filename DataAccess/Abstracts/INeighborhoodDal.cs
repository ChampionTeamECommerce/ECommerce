using System;
using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface INeighborhoodDal : IRepository<Neighborhood, Guid>, IAsyncRepository<Neighborhood, Guid>
    {

    }
}

