using Castle.Core.Resource;
using ECommerce.Business.Abstract;
using ECommerce.Business.Constants;
using ECommerce.Common.Utilities.Results;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Concrete.EntityFramework;
using ECommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Concrete
{
    public class CreditCardManager : ICreditCardService
    {
        ICreditCardDal _creditCardDal;
        public CreditCardManager(ICreditCardDal creditCardDal)
        {
            _creditCardDal = creditCardDal;
        }

        public CreditCard GetByCardId(int cardId)
        {
            return _creditCardDal.Get(c => c.CardID == cardId);
        }

        IResult ICreditCardService.AddCard(CreditCard creditCard)
        {
            _creditCardDal.Add(creditCard);
            return new SuccessResult(Messages.CardAdded);
        }

        IResult ICreditCardService.DeleteCard(CreditCard creditCard)
        {
            _creditCardDal.Delete(creditCard);
            return new SuccessResult(Messages.CardDelete);
        }

        IResult ICreditCardService.UpdateCard(CreditCard creditCard)
        {
            _creditCardDal.Update(creditCard);
            return new SuccessResult(Messages.CardUpdate);
        }
    }

}
