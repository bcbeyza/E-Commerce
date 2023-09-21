using ECommerce.Common.Utilities.Results;
using ECommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface ICartService
    {
        IResult AddToCart(Cart cart);

        IResult DeleteFromCart(Cart cart);

        IResult UpdateCard(Cart cart);
        IDataResult<List<Cart>> GetAll();
        IDataResult<Cart> GetById(int id);
    }
}
