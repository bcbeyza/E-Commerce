using ECommerce.Common.Utilities.Results;
using ECommerce.Entities.Concrete;
using ECommerce.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer customer);
        IResult UpdateAddress(Customer customer, string newAddress);
        IResult RemoveCustomer(Customer customer);

        Customer GetByEmail(string email);
        Customer GetById(int id);
        Customer GetByPassword(string password);

        IResult Login(CustomerForLoginDto customerForLoginDto);
    }
}
