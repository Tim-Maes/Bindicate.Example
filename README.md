# Bindicate.Example
Example of how DI autowiring is configured using Bindicate 

## Bindicate.Host

This project is a default scaffolded .NET API & Angular template. Project and ProjectWithOptions are referenced.
In the WeatherController we inject the services that are added to the `IServiceCollection` from the other projects and use them.
We pass the configuration to the project that needs `IOptions<T>`

## Bindicate.Project

This projects holds a few services that are decorated with Bindicate attributes.

## Bindicate.ProjectWithOptions

This project holds a service that uses `IOptions<T>` to use values from `appsettings.json` which are also decorated with Bindicate attributes.
