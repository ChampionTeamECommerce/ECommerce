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
    public class EfOperationClaimDal : EfRepositoryBase<OperationClaim, Guid, MsSqlDbContext>, IOperationClaimDal
    {
        public EfOperationClaimDal(MsSqlDbContext context) : base(context)
        {
        }
    }
}
