using Castle.Core.Resource;
using ECommerce.Business.Abstract;
using ECommerce.Business.Constants;
using ECommerce.Common.Utilities.Results;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Concrete.EntityFramework;
using ECommerce.Entities.Concrete;
using ECommerce.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Concrete
{
    public class FavouriteListManager : IFavouriteListService
    {
        IFavouriteListDal _favouriteListDal;
        ICustomerService _customerService;
        IProductService _productService;
        public FavouriteListManager(IFavouriteListDal favouriteListDal, ICustomerService customerService, IProductService productService)
        {
            _favouriteListDal = favouriteListDal;
            _customerService = customerService;
            _productService = productService;
        }

        public IResult AddToFavouriteList(FavouriteList favouriteList)
        {
            try
            {
                // Önce veritabanında ilgili müşteriyi ve ürünü bulun
                var customer = _customerService.GetById(favouriteList.CustomerID);
                var product = _productService.GetById(favouriteList.ProductID);

                if (customer == null || product == null)
                {
                    return new ErrorResult("Müşteri veya ürün bulunamadı.");
                }

                // Favori listeye eklemek için gerekli işlemleri yapın (örneğin, veritabanına ekleyin)
                var favoriteList = new FavouriteList
                {
                    ProductID= favouriteList.ProductID,
                    CustomerID = favouriteList.CustomerID,
                    FavouriteID = favouriteList.FavouriteID,
                    // FavouriteListID veya diğer özellikleri doldurabilirsiniz
                };

                _favouriteListDal.Add(favoriteList);
               
                return new SuccessResult("Ürün favorilere eklendi.");
            }
            catch (Exception ex)
            {
                // Hata durumlarını işleyin ve gerekirse uygun bir hata mesajı dönün
                return new ErrorResult($"Ürün favorilere eklenirken bir hata oluştu: {ex.Message}");
            }
        }

        public IDataResult<List<FavouriteList>> GetAll()
        {
            return new SuccessDataResult<List<FavouriteList>>(_favouriteListDal.GetAll());
        }

        public IResult RemoveFromFavouriteList(FavouriteList favouriteList)
        {
            try
            {
                // Önce veritabanında ilgili müşteriyi ve ürünü bulun
                var customer = _customerService.GetById(favouriteList.CustomerID);
                var product = _productService.GetById(favouriteList.ProductID);

                if (customer == null || product == null)
                {
                    return new ErrorResult("Müşteri veya ürün bulunamadı.");
                }

                // Favori listeye eklemek için gerekli işlemleri yapın (örneğin, veritabanına ekleyin)
                var favoriteList = new FavouriteList
                {
                    ProductID = favouriteList.ProductID,
                    CustomerID = favouriteList.CustomerID,
                    FavouriteID = favouriteList.FavouriteID,
                    // FavouriteListID veya diğer özellikleri doldurabilirsiniz
                };

                _favouriteListDal.Delete(favoriteList);

                return new SuccessResult("Ürün favorilerden silindi.");
            }
            catch (Exception ex)
            {
                // Hata durumlarını işleyin ve gerekirse uygun bir hata mesajı dönün
                return new ErrorResult($"Ürün favorilerden silinirken bir hata oluştu: {ex.Message}");
            }
        }
    }
}
