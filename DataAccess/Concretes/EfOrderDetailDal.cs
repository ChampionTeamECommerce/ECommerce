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
    public class EfOrderDetailDal : EfRepositoryBase<OrderDetail, Guid, MsSqlDbContext>, IOrderDetailDal
    {
        public EfOrderDetailDal(MsSqlDbContext context) : base(context)
        {
        }
    }
}
