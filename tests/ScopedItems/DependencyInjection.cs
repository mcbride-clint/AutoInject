using AutoInject;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ScopedItems
{
    public static class DependencyInjection
    {
        public static void AddScopedClasses(IServiceCollection services)
        {
            services.AddInjectablesIn(Assembly.GetExecutingAssembly());
        }
    }
}
