using ECommerce.Business.Abstract;
using ECommerce.Business.Constants;
using ECommerce.Common.Utilities.Results;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Concrete.EntityFramework;
using ECommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Concrete
{
    public class CartManager : ICartService
    {
        ICartDal _cartDal;
        IProductService _productService;
        ICustomerService _customerService;
        public CartManager(ICartDal cartDal, IProductService productService, ICustomerService customerService)
        {
            _cartDal = cartDal;
            _productService = productService;
            _customerService = customerService;

        }
        public IResult AddToCart(Cart cart)
        {
            var product = _productService.GetById(cart.ProductID);
            var eklenecek = new Cart
            {
                ProductID = cart.ProductID,
                CartID = cart.CartID,
                CustomerID= cart.CustomerID
                // FavouriteListID veya diğer özellikleri doldurabilirsiniz
            };
            _cartDal.Add(cart);
            return new SuccessResult(Messages.AddToCart);
        }
        
        public IResult DeleteFromCart(Cart cart)
        {
            try
            {
                // Önce veritabanında ilgili müşteriyi ve ürünü bulun
                var product = _productService.GetById(cart.ProductID);
                // Favori listeye eklemek için gerekli işlemleri yapın (örneğin, veritabanına ekleyin)
                var silinecek = new Cart
                {
                    ProductID = cart.ProductID,
                    CartID = cart.CartID,
                    // FavouriteListID veya diğer özellikleri doldurabilirsiniz
                };

                _cartDal.Delete(cart);

                return new SuccessResult("Ürün favorilerden silindi.");
            }
            catch (Exception ex)
            {
                // Hata durumlarını işleyin ve gerekirse uygun bir hata mesajı dönün
                return new ErrorResult($"Ürün favorilerden silinirken bir hata oluştu: {ex.Message}");
            }
        }

        public IResult UpdateCard(Cart cart)
        {
            try
            {
                // Önce veritabanında ilgili müşteriyi ve ürünü bulun
                var product = _productService.GetById(cart.ProductID);
                // Favori listeye eklemek için gerekli işlemleri yapın (örneğin, veritabanına ekleyin)
                var silinecek = new Cart
                {
                    ProductID = cart.ProductID,
                    CartID = cart.CartID,
                    // FavouriteListID veya diğer özellikleri doldurabilirsiniz
                };

                _cartDal.Update(cart);

                return new SuccessResult("Ürün favorilerden silindi.");
            }
            catch (Exception ex)
            {
                // Hata durumlarını işleyin ve gerekirse uygun bir hata mesajı dönün
                return new ErrorResult($"Ürün favorilerden silinirken bir hata oluştu: {ex.Message}");
            }
        }

        public IDataResult<List<Cart>> GetAll()
        {
            return new SuccessDataResult<List<Cart>>(_cartDal.GetAll(), Messages.ProductsListed);
        }
        public IDataResult<Cart> GetById(int id)
        {
            return new SuccessDataResult<Cart>(_cartDal.Get(p => p.ProductID == id)); 
        }
        

        
    }
}
