using AutoInject;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace SingletonItems
{
    public static class DependencyInjection
    {
        public static void AddSingletonClasses(IServiceCollection services)
        {
            services.AddInjectablesIn(Assembly.GetExecutingAssembly());
        }
    }
}
