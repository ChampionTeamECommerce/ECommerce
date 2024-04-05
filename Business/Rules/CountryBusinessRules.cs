using Core.Business.Rules;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class CountryBusinessRules:BaseBusinessRules
    {
        ICountryDal _CountryDal;

        public CountryBusinessRules(ICountryDal CountryDal)
        {
            _CountryDal = CountryDal;
        }
    }
}
