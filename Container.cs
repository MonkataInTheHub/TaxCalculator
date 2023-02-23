using Autofac;
using Autofac.Core;
using Backend.Interfaces;
using Backend.Models;
using Backend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public static class Container
    {
        public static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            //Here you should register Interfaces with their referent classes
            builder.RegisterType<ApplicationService>();
            builder.RegisterType<Writer>().As<IWriter>();
            builder.RegisterType<Reader>().As<IReader>();
            builder.RegisterType<Validator>().As<IValidator>();
            builder.RegisterType<TaxCalculator>().As<ITaxCalculator>();
            builder.RegisterType<IncomeTax>();
            builder.RegisterType<SocialContributionTax>();
            builder.RegisterType<MovieStar>().As<IMovieStar>();

            return builder.Build();
        }
    }
}
