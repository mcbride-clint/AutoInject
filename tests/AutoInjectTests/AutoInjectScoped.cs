using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoInjectTests
{
    [TestClass]
    public class AutoInjectScoped
    {
        [TestMethod]
        public void TestScopedCollection()
        {
            var services = new ServiceCollection();
            ScopedItems.DependencyInjection.AddScopedClasses(services);

            foreach (var service in services)
            {
                service.VerifyImplementation(ServiceLifetime.Scoped);
            }
        }
    }
}
