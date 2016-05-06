using Autofac;
using Autofac.Integration.Wcf;
using ClassLibraryDomain;
using ClassLibraryInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceShopCenter.App_Start
{
 

    public static class AutofacConfig
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();


            builder.RegisterType<RepositoryArticle>().As<IRepositoryArticle>();
            //builder.RegisterType<RepositorySaleTransaction>().As<IRepositorySaleTransaction>();
            //builder.RegisterType<RepositoryDetailSaleTransaction>().As<IRepositoryDetailSaleTransaction>();
            builder.RegisterType<AppContext>().As<IRepository>().As<IUnitOfWork>().InstancePerLifetimeScope();

            //builder.RegisterType<WcfServiceShopCenter.ServiceSaleDetail>();

            //builder.RegisterType<WcfServiceShopCenter.ServiceSale>();

            builder.RegisterType<WcfServiceShopCenter.ServiceArticle>();

            var container = builder.Build();
            AutofacHostFactory.Container = container;

        }
    }

}