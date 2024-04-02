using Core.Business.Rules;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class AddressBusinessRules: BaseBusinessRules
    {
        IAddressDal _addressDal;

        public AddressBusinessRules(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }


    }
}
