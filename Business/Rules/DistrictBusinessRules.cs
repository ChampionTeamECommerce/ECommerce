using Core.Business.Rules;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class DistrictBusinessRules : BaseBusinessRules
    {
        IDistrictDal _DistrictDal;

        public DistrictBusinessRules(IDistrictDal DistrictDal)
        {
            _DistrictDal = DistrictDal;
        }
    }
}
