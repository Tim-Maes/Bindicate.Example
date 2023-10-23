using Bindicate.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Bindicate.ProjectWithOptions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddProjectWithOptions(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAutowiringForAssembly(Assembly.GetExecutingAssembly())
            .WithOptions(configuration)
            .Register();

        return services;
    }
}
