using ECommerce.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities.Concrete
{
    public class FavouriteList:IEntity
    {
        public int FavouriteID { get; set; }
        public int ProductID { get; set; }
        public int CustomerID { get; set; }
    }
}
