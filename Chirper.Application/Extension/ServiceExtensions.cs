using MediatR;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using System.Reflection;
using AutoMapper;
using Microsoft.Extensions.Configuration;


namespace Chirper.Application.Extension
{
    public static class ServiceExtensions
    {
        public static void AddConfigureApplication(this IServiceCollection services)
        {
             services.AddAutoMapper(Assembly.GetExecutingAssembly());
             services.AddMediatR(Assembly.GetExecutingAssembly());
             services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
