using ECommerce.Common.Utilities.Results;
using ECommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface IProductService
    {
        IResult AddProduct(Product product);
        IResult DeleteProduct(Product product);
        IResult UpdateProduct(Product product);
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetAllByBrandId(int id);
        IDataResult<List<Product>> GetAllByColorId(int id);
        IDataResult<Product> GetById(int productId);

    }
}
