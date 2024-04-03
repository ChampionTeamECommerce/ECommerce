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
    public class ProductBusinessRules: BaseBusinessRules
    {
        IProductDal _productDal;

        public ProductBusinessRules(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public async Task ProductCannotBeDuplicated(string name)
        {
            var productToCheck = await _productDal.GetAsync(b => b.Name == name);
            if (productToCheck != null)
            {
                throw new BusinessException(ProductMessages.ProductAlreadyExist);
            }
        }
    }
}
