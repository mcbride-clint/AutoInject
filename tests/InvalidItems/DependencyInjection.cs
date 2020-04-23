using AutoInject;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace InvalidItems
{
    public static class DependencyInjection
    {
        public static void AddInvalidClasses(IServiceCollection services)
        {
            services.AddInjectablesIn(Assembly.GetExecutingAssembly());
        }
    }
}
