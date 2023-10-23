using Bindicate.Attributes;
using Microsoft.Extensions.Options;

namespace Bindicate.ProjectWithOptions.Services;

[AddScoped(typeof(IServiceWithOptions))]
public class ServiceWithOptions : IServiceWithOptions
{
    private readonly IOptions<SampleOptions> _options;

    public ServiceWithOptions(IOptions<SampleOptions> options)
    {
        _options = options;
    }

    public string CombineOptions(string input) => $"{input}_{_options.Value.SampleStringOption}_{_options.Value.SampleNumberOption}";
}

public interface IServiceWithOptions
{
    string CombineOptions(string input);
}