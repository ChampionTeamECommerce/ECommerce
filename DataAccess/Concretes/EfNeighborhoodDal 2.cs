using System;
using Core.DataAccess.Repository;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfNeighborhoodDal : EfRepositoryBase<Neighborhood, Guid, MsSqlDbContext>, INeighborhoodDal
    {
        public EfNeighborhoodDal(MsSqlDbContext context) : base(context)
        {
        }
    }
}

