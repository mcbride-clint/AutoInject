using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoInjectTests
{
    [TestClass]
    public class AutoInjectTransient
    {
        [TestMethod]
        public void TestTransientCollection()
        {
            var services = new ServiceCollection();
            TransientItems.DependencyInjection.AddTransientClasses(services);

            foreach (var service in services)
            {
                service.VerifyImplementation(ServiceLifetime.Transient);
            }
        }
    }
}
