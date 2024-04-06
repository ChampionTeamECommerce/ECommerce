using System;
using Core.DataAccess.Repository;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfGenderDal : EfRepositoryBase<Gender, Guid, MsSqlDbContext>, IGenderDal
    {
        public EfGenderDal(MsSqlDbContext context) : base(context)
        {
        }
    }
}

