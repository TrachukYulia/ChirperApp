using MediatR;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using System.Reflection;
using AutoMapper;
using Chirper.Application.Handlers;
using Microsoft.Extensions.Configuration;


namespace Chirper.Application.Extension
{
    public static class IServiceCollectionExtensions
    {
        public static void AddConfigureApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidatorErrorHandler<,>));

        }
    }
}
