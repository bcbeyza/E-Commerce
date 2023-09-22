using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using ECommerce.Business.Abstract;
using ECommerce.Business.Concrete;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Concrete.EntityFramework;


namespace ECommerce.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        //uygulama ayağa kalktığında burası çalışacak load ile
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();

            builder.RegisterType<CustomerManager>().As<ICustomerService>().SingleInstance();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>().SingleInstance();

            builder.RegisterType<CreditCardManager>().As<ICreditCardService>().SingleInstance();
            builder.RegisterType<EfCreditCardDal>().As<ICreditCardDal>().SingleInstance();

            builder.RegisterType<FavouriteListManager>().As<IFavouriteListService>().SingleInstance();
            builder.RegisterType<EfFavouriteListDal>().As<IFavouriteListDal>().SingleInstance();

            builder.RegisterType<CartManager>().As<ICartService>().SingleInstance();
            builder.RegisterType<EfCartDal>().As<ICartDal>().SingleInstance();

            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();


            builder.RegisterType<BrandManager>().As<IBrandService>().SingleInstance();
            builder.RegisterType<EfBrandDal>().As<IBrandDal>().SingleInstance();

            builder.RegisterType<ColorManager>().As<IColorService>().SingleInstance();
            builder.RegisterType<EfColorDal>().As<IColorDal>().SingleInstance();

        }



    }
}
