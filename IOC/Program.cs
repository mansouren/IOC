using Autofac;
using System;
using Unity;

namespace IOC
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Without Ioc Container
            //var shopper = new Shopper(new Visa());
            //shopper.Charge();
            #endregion

            #region Asp.net Core Ioc Container
            var resolver = new Resolver();
            resolver.Register<Shopper, Shopper>();
            resolver.Register<ICreditCard, Visa>();

            var shopper = resolver.Resolve<Shopper>();
            shopper.Charge();
            #endregion

            #region Autofac Ioc container
            //var containerBuilder = new ContainerBuilder();
            //containerBuilder.RegisterType<Master>().As<ICreditCard>().InstancePerLifetimeScope();
            //containerBuilder.RegisterType<Shopper>().AsSelf().InstancePerLifetimeScope();
            //var container = containerBuilder.Build();
            //var shopper = container.Resolve<Shopper>();
            //shopper.Charge();
            #endregion

            #region Unity Ioc Container
            //var container = new UnityContainer();
            //container.RegisterType<ICreditCard, Master>();
            //var shopper = container.Resolve<Shopper>();
            //shopper.Charge();
            #endregion

        }
    }
}
