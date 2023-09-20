using ECommerce.Common.Utilities.Results;
using ECommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface ICreditCardService
    {
        IResult AddCard(CreditCard creditCard);

        IResult DeleteCard(CreditCard creditCard);

        IResult UpdateCard(CreditCard creditCard);
        CreditCard GetByCardId(int cardId);
    }

}
