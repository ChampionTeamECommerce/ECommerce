using System;
using Core.DataAccess.Repository;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes
{

        public class EfSizeDal : EfRepositoryBase<Size, Guid, MsSqlDbContext>, ISizeDal
        {
            public EfSizeDal(MsSqlDbContext context) : base(context)
            {
            }
        }
}

