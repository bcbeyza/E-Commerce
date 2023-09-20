using ECommerce.Common.DataAccess;
using ECommerce.Common.EntityFramework;
using ECommerce.DataAccess.Concrete.EntityFramework;
using ECommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
       
    }
}
