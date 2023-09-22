using ECommerce.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.ValidationRules.FluentValidation
{
    public class CartValidator:AbstractValidator<Cart>
    {
        public CartValidator()
        {
            
        }
    }
}
