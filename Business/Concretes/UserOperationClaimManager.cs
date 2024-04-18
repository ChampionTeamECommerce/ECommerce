using Business.Abstracts;
using Core.Entity.Concrete;
using DataAccess.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class UserOperationClaimManager: IUserOperationClaimService
    {
        private readonly IUserOperationClaimDal _userOperationClaimDal;

        public UserOperationClaimManager(IUserOperationClaimDal userOperationClaimDal)
        {
            _userOperationClaimDal = userOperationClaimDal;
        }

        public async Task<IList<OperationClaim>> GetClaims(Guid id)
        {
            var userOperationClaims = await _userOperationClaimDal.GetListAsync(u => u.UserId == id,
                                                                   include: u => u.Include(u => u.OperationClaim));
            IList<OperationClaim> operationClaims =
                userOperationClaims.Items.Select(u => new OperationClaim
                { Id = u.OperationClaim.Id, Name = u.OperationClaim.Name }).ToList();
            return operationClaims;
        }
    }
 
}
