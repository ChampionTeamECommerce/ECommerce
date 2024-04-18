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
    public class EfUserDal : EfRepositoryBase<User, Guid, MsSqlDbContext>, IUserDal
    {
        public EfUserDal(MsSqlDbContext context) : base(context)
        {
        }


      
    }
}
