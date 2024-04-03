using Business.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class CityBusinessRules :BaseBusinessRules
    {
        ICityDal _cityDal;

        public CityBusinessRules(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public async Task CityCannotBeDuplicated(string name)
        {
            var cityToCheck = await _cityDal.GetAsync(b => b.Name == name);

            if (cityToCheck != null)
            {
                throw new BusinessException(CityMessages.CityAlreadyExist);
            }
        }
    }
}
