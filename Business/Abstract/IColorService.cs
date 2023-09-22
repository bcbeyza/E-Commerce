using ECommerce.Common.Utilities.Results;
using ECommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface IColorService
    {
        IResult Add(Color color);
        IResult Delete(Color color);
    }
}
