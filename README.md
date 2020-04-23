# AutoInject
.Net Core Library to Mark Classes as Injectable and Add them to your Service Collection

## Usage

AutoInject has six Interfaces to identify the lifetime of the dependency.
    
Injects an instance of itself:

* `IInjectScoped`
* `IInjectTransient`
* `IInjectSingleton`

Example
    
    public class OrderService : IInjectScoped

Injects an instance of itself for a given Interface:
    
* `IInjectScoped<ImplementationInterface>`
* `IInjectTransient<ImplementationInterface>`
* `IInjectSingleton<ImplementationInterface>`

Example

    public class OrderRepository : IOrderRepository, IInjectScoped<IOrderRepository>

Once objects are Identified, AutoInject can be performed as an extension method on `IServiceCollection`. Method must be given a reference to the Assembly that you want to be searched for available Injectable objects.

    using AutoInject;
    ...
    ...
    services.AddInjectablesIn(Assembly.GetExecutingAssembly());
