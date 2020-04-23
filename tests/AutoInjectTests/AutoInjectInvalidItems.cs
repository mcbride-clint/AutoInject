using AutoInject;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoInjectTests
{
    [TestClass]
    public class AutoInvalidScoped
    {
        [TestMethod]
        public void TestInvalidCollection()
        {
            var services = new ServiceCollection();

            Assert.ThrowsException<InvalidInjectableException>(
                () => InvalidItems.DependencyInjection.AddInvalidClasses(services));
        }
    }
}
