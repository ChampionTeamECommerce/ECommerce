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
    public class CategoryBusinessRules:BaseBusinessRules
    {
        ICategoryDal _categoryDal;

        public CategoryBusinessRules(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public async Task CategoryCannotBeDuplicated(string name)
        {
            var categoryToCheck = await _categoryDal.GetAsync(b => b.Name == name);
            if (categoryToCheck != null)
            {
                throw new BusinessException(CategoryMessages.CategoryAlreadyExist);
            }
        }
    }
}
