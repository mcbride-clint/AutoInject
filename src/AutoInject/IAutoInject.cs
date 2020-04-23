using System;
using System.Collections.Generic;
using System.Text;

namespace AutoInject
{
    public interface IAutoInject
    {
    }


    public interface IAutoInjectScoped : IAutoInject
    {
    }

    public interface IAutoInjectScoped<IInjectType> : IAutoInject
    {
    }

    public interface IAutoInjectTransient : IAutoInject
    {
    }

    public interface IAutoInjectTransient<IInjectType> : IAutoInject
    {
    }

    public interface IAutoInjectSingleton : IAutoInject
    {
    }

    public interface IAutoInjectSingleton<IInjectType> : IAutoInject
    {
    }
}
