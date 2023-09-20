using ECommerce.Common.EntityFramework;
using ECommerce.DataAccess.Abstract;
using ECommerce.Entities.Concrete.EntityFramework;
using ECommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ECommerceContext>, ICustomerDal
    {
    }
}
