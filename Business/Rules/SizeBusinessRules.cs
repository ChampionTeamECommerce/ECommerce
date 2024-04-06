using System;
using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules
{
        public class SizeBusinessRules : BaseBusinessRules
        {
        ISizeDal _sizeDal;

            public SizeBusinessRules(ISizeDal sizeDal)
            {
            _sizeDal = sizeDal;
            }


        }
    
}

