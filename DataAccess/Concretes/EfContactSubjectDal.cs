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
    internal class EfContactSubjectDal : EfRepositoryBase<ContactSubject, Guid, MsSqlDbContext>, IContactSubjectDal
    {
        public EfContactSubjectDal(MsSqlDbContext context) : base(context)
        {
        }
    }
}
