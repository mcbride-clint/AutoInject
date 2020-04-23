using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoInjectTests
{
    public static class Common
    {
        public static void VerifyImplementation(this ServiceDescriptor service, ServiceLifetime lifetime)
        {
            Assert.IsTrue(service.Lifetime == lifetime);

            var genericImplementations = service.ImplementationType.GetInterfaces().Where(i => i.IsGenericType);

            if (genericImplementations.Any())
            {
                Assert.AreEqual(service.ServiceType, genericImplementations.First().GenericTypeArguments[0]);
            }
            else
            {
                Assert.AreEqual(service.ServiceType, service.ImplementationType);
            }
        }
    }
}
