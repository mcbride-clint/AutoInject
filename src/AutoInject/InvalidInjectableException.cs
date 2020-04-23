using System;
using System.Collections.Generic;
using System.Text;

namespace AutoInject
{
    public class InvalidInjectableException : Exception
    {
        public InvalidInjectableException(Type injectable, Exception ex)
            : base($"Could not verify Lifetime of AutoInject object. Do not implement IAutoInject directly. " +
                  $"{injectable.Name}", ex)
        { }

        public InvalidInjectableException(Type injectable)
            : this(injectable, null)
        { }
    }
}
