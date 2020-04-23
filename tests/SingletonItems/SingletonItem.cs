using AutoInject;

namespace SingletonItems
{
    public class SingletonItem : IAutoInjectSingleton { }

    public class SingletonItemInstance : IAutoInjectSingleton<ISingletonItem> { }

    public interface ISingletonItem { }
}
