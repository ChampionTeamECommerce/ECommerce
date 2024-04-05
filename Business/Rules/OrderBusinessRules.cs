using Core.Business.Rules;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class OrderBusinessRules : BaseBusinessRules
    {
        IOrderDal _OrderDal;

        public OrderBusinessRules(IOrderDal OrderDal)
        {
            _OrderDal = OrderDal;
        }
    }
}
