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


    public class ContactUsBusinessRules : BaseBusinessRules
    {

        IContactUsDal _contactUsDal;

        public ContactUsBusinessRules(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public async Task ContactUsCannotBeDuplicated(string name)
        {
            var contactUsToCheck = await _contactUsDal.GetAsync(b => b.FirstName == name);

            if (contactUsToCheck != null)
            {
                throw new BusinessException(ContactUsMessages.ContactUsAlreadyExist);
            }
        }


    }
}
