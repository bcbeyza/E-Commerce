﻿using ECommerce.Common.DataAccess;
using ECommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.Abstract
{
    public interface IBrandDal : IEntityRepository<Brand>
    {
    }
}
