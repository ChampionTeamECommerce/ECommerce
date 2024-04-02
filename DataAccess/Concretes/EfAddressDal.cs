using Core.DataAccess.Repository;
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
    public class EfAddressDal : EfRepositoryBase<Address, Guid, MsSqlDbContext>, IAddressDal
    {
        public EfAddressDal(MsSqlDbContext context) : base(context)
        {
        }
    }
}
