using System;
using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules
{

	
        public class UserAddressesBusinessRules : BaseBusinessRules
        {
            IUserAddressesDal _userAddressesDal;

            public UserAddressesBusinessRules(IUserAddressesDal userAddressesDal)
            {
                _userAddressesDal = userAddressesDal;
            }


        }
    
}

