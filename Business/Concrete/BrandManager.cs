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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.MarkaEklendi);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.MarkaSilindi);
        }

    }
}
