using ECommerce.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities.Concrete
{
    public class CreditCard : IEntity
    {
        public int CardID { get; set; }
        public int CustomerID { get; set; }
        public DateTime CardExpDate { get; set; }
        public int CardCVV { get; set; }
        public string CardNumber { get; set; }
    }

}
