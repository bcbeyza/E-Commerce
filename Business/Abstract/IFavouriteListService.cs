using ECommerce.Common.Utilities.Results;
using ECommerce.Entities.Concrete;
using ECommerce.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface IFavouriteListService
    {
        IResult AddToFavouriteList(FavouriteList favouriteList);
        IResult RemoveFromFavouriteList(FavouriteList favouriteList);
        IDataResult<List<FavouriteList>> GetAll();
    }
}
