using AutoInject;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace TransientItems
{
    public static class DependencyInjection
    {
        public static void AddTransientClasses(IServiceCollection services)
        {
            services.AddInjectablesIn(Assembly.GetExecutingAssembly());
        }
    }
}
