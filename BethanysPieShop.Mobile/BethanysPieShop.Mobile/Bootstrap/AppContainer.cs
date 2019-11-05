using Autofac;
using BethanysPieShop.Mobile.Core.Contracts.Repository;
using BethanysPieShop.Mobile.Core.Contracts.Services.Data;
using BethanysPieShop.Mobile.Core.Contracts.Services.General;
using BethanysPieShop.Mobile.Core.Repository;
using BethanysPieShop.Mobile.Core.Services.Data;
using BethanysPieShop.Mobile.Core.Services.General;
using BethanysPieShop.Mobile.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BethanysPieShop.Mobile.Core.Bootstrap
{
    public class AppContainer
    {
        private static IContainer _container;

        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            //ViewModels
            builder.RegisterType<AppShellModel>();
            builder.RegisterType<HomeViewModel>();
            builder.RegisterType<PieCatalogViewModel>();

            //services - data
            builder.RegisterType<CatalogDataService>().As<ICatalogDataService>();

            //services - navigation
            builder.RegisterType<ShellNavigationService>().As<INavigationService>().SingleInstance();
            //builder.RegisterInstance(new ShellNavigationService()).As<INavigationService>();

            //General
            builder.RegisterType<GenericRepository>().As<IGenericRepository>();

            _container = builder.Build();
        }

        public static object Resolve(Type typeName)
        {
            return _container.Resolve(typeName);
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
