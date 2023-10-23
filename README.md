# Bindicate.Example
Example of how DI autowiring is configured using Bindicate 

## Bindicate.Host

This project is a default scaffolded .NET API & Angular template. Project and ProjectWithOptions are referenced and they both use Bindicate to decorate the services.
In the WeatherForecastController we inject the services that are added to the `IServiceCollection` from the other projects and use them.
We pass the configuration to the project that needs `IOptions<T>`

## Bindicate.Project

This projects holds a few services that are decorated with Bindicate attributes.

## Bindicate.ProjectWithOptions

This project holds a service that uses `IOptions<T>` to use values from `appsettings.json` which are also decorated with Bindicate attributes.<

### Testing

Just run the solution with `Bindicate.Host` as startup project and navigate to 'fetch data'.
If you set a breakpoint in the WeatherForecastController method, you see that the injected services are working.
