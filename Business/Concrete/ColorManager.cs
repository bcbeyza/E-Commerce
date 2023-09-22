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
    public class ColorManager:IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal=colorDal;
        }

        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.RenkEklendi);
        }
        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.RenkEklendi);
        }
    }
}
