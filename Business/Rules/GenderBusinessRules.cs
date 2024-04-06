using System;
using Business.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;

namespace Business.Rules
{
    public class GenderBusinessRules : BaseBusinessRules
    {
        IGenderDal _genderDal;

        public GenderBusinessRules(IGenderDal genderDal)
        {
            _genderDal = genderDal;
        }

     

    }
}

