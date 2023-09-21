using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities.DTOs
{
    public class ForFavouriteListDto
    {
        public int CustomerID{ get; set; }
        public int ProductID { get; set; }
        public int FavouriteListID { get; set; }
    }
}
