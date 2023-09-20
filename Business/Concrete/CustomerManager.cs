using ECommerce.Business.Abstract;
using ECommerce.Business.Constants;
using ECommerce.Business.ValidationRules.FluentValidation;
using ECommerce.Common.Utilities.Results;
using ECommerce.DataAccess.Abstract;
using ECommerce.Entities.Concrete;
using ECommerce.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
              _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public Customer GetByEmail(string email)
        {
            return _customerDal.Get(c => c.Email == email);

        }

        public Customer GetByPassword(string password)
        {
            return _customerDal.Get(c => c.Password == password);
        }

        public IResult Login(CustomerForLoginDto customerForLoginDto)
        {
            var customerToCheckPassword = GetByPassword(customerForLoginDto.Password);
            var customerToCheckEmail = GetByEmail(customerForLoginDto.Email);

            if (customerToCheckPassword != null && customerToCheckEmail != null)
            {
                return new SuccessResult(Messages.LoginSuccesful); ;
            }
            return new SuccessResult(Messages.LoginError); ;

        }

        public IResult RemoveCustomer(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.RemoveCustomer);

        }
    }
}
