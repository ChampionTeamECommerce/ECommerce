using Core.DataAccess.Repository;
using Core.Entity.Concrete;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class EfUserOperationClaimDal : EfRepositoryBase<UserOperationClaim, Guid, MsSqlDbContext>, IUserOperationClaimDal
    {
        public EfUserOperationClaimDal(MsSqlDbContext context) : base(context)
        {
        }
    }
}
