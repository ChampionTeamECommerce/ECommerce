using System;
using Business.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using DataAccess.Concretes;

namespace Business.Rules
{
    public class NeighborhoodBusinessRules : BaseBusinessRules
    {
        INeighborhoodDal _neighborhoodDal;

        public NeighborhoodBusinessRules(INeighborhoodDal neighborhoodDal)
        {
            _neighborhoodDal = neighborhoodDal;
        }

        


    }
}

