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
    public class EfCityDal : EfRepositoryBase<City, Guid, MsSqlDbContext>, ICityDal
    {
        public EfCityDal(MsSqlDbContext context) : base(context)
        {
        }
    }
}
