using System;
using Core.DataAccess.Repository;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfUserAddressesDal : EfRepositoryBase<UserAddresses, Guid, MsSqlDbContext>, IUserAddressesDal
    {
        public EfUserAddressesDal(MsSqlDbContext context) : base(context)
        {
        }
    }
}

