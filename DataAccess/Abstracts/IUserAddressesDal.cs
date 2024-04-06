using System;
using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IUserAddressesDal : IRepository<UserAddresses, Guid>, IAsyncRepository<UserAddresses, Guid>
    {
    }
}

