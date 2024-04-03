using Business.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class ContactSubjectRules
    {
        public class ContactSubjectBusinessRules : BaseBusinessRules
        {
            IContactSubjectDal _contactSubjectDal;

            public ContactSubjectBusinessRules(IContactSubjectDal contactSubjectDal)
            {
                _contactSubjectDal = contactSubjectDal;
            }

            public async Task ContactSubjectCannotBeDuplicated(string name)
            {
                var contactSubjectToCheck = await _contactSubjectDal.GetAsync(b => b.Name == name);

                if (contactSubjectToCheck != null)
                {
                    throw new BusinessException(ContactSubjectMessages.ContactSubjectAlreadyExist);
                }
            }


        }
    }
}
