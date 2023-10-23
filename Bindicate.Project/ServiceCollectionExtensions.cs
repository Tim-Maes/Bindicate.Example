using Bindicate.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Bindicate.Project;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddProject(this IServiceCollection services)
    {
        //Registers all services decorated with attribute
        services.AddAutowiringForAssembly(Assembly.GetExecutingAssembly());

        return services;
    }
}