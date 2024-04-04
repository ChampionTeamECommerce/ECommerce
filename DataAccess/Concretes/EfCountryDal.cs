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
    public class EfCountryDal : EfRepositoryBase<Country, Guid, MsSqlDbContext>, ICountryDal
    {
        public EfCountryDal(MsSqlDbContext context) : base(context)
        {
        }
    }
}
