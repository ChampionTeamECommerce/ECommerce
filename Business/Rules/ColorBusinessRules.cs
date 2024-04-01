using Business.Abstracts;
using Business.DTOs.Color.Request;
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
    public class ColorBusinessRules: BaseBusinessRules
    {
        IColorDal _colorDal;

        public ColorBusinessRules(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public async Task ColorCannotBeDuplicated(string name)
        {
            var colorToCheck = await _colorDal.GetAsync(b => b.Name == name);

            if (colorToCheck != null)
            {
                throw new BusinessException(ColorMessages.ColorAlreadyExist);
            }
        }

        
    }
}
