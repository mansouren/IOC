using Autofac;
using Autofac.Extensions.DependencyInjection;
using Ioc.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ioc.Core.Extensions
{
    public static class AutoFacExtensionMethods
    {
        public static void AddServices(this ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<MasterService>().As<ICreditCard>().InstancePerLifetimeScope();
        }

        //We don't need this since Autofac updates for ASP.NET Core 3.0+ Generic Hosting
        //public static IServiceProvider BuildAutofacServiceProvider(this IServiceCollection services)
        //{
        //    var containerBuilder = new ContainerBuilder();
        //    containerBuilder.Populate(services); // Add Services that are Registered in StartUp's ConfigureServices into conatinerBuilder
        //    var container = containerBuilder.Build(); //Return IContainer that inherits from Ilifetimescope
        //    return new AutofacServiceProvider(container);//need a parameter type of Ilifetimescope
        //}
    }
}
