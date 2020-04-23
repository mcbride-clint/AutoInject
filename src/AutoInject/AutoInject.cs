using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Reflection;

namespace AutoInject
{
    public static class AutoInject
    {
        public static void AddInjectablesIn(this IServiceCollection services, Assembly assembly)
        {
            var foundInjectables = assembly.GetExportedTypes()
                .Where(t => t.GetInterfaces().Any(i => i.UnderlyingSystemType == typeof(IAutoInject)))
                .ToList();


            foundInjectables.ForEach(injectable =>
            {
                var interfaceType = injectable.GetInterfaces()
                    .SingleOrDefault(i => i.GetInterfaces().Any(ii => ii.UnderlyingSystemType == typeof(IAutoInject)));

                if(interfaceType is null)
                {
                    throw new InvalidInjectableException(injectable);
                }

                if (interfaceType.IsGenericType)
                {
                    if (injectable.GetInterface("IAutoInjectScoped`1") != null)
                    {
                        services.AddScoped(interfaceType.GenericTypeArguments[0], injectable);
                    }
                    else if (injectable.GetInterface("IAutoInjectTransient`1") != null)
                    {
                        services.AddTransient(interfaceType.GenericTypeArguments[0], injectable);
                    }
                    else if (injectable.GetInterface("IAutoInjectSingleton`1") != null)
                    {
                        services.AddSingleton(interfaceType.GenericTypeArguments[0], injectable);
                    }
                }
                else
                {
                    if (interfaceType == typeof(IAutoInjectScoped))
                    {
                        services.AddScoped(injectable);
                    }
                    else if (interfaceType == typeof(IAutoInjectTransient))
                    {
                        services.AddTransient(injectable);
                    }
                    else if (interfaceType == typeof(IAutoInjectSingleton))
                    {
                        services.AddSingleton(injectable);
                    }
                }
            });
        }
    }
}
