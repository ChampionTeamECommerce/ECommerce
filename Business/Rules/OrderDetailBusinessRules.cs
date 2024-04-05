using Core.Business.Rules;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class OrderDetailBusinessRules : BaseBusinessRules
    {
        IOrderDetailDal _OrderDetailDal;

        public OrderDetailBusinessRules(IOrderDetailDal OrderDetailDal)
        {
            _OrderDetailDal = OrderDetailDal;
        }
    }
}
