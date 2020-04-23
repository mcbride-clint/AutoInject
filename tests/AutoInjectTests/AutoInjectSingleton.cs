using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoInjectTests
{
    [TestClass]
    public class AutoInjectSingleton
    {
        [TestMethod]
        public void TestSingletonCollection()
        {
            var services = new ServiceCollection();
            SingletonItems.DependencyInjection.AddSingletonClasses(services);

            foreach (var service in services)
            {
                service.VerifyImplementation(ServiceLifetime.Singleton);
            }
        }
    }
}
