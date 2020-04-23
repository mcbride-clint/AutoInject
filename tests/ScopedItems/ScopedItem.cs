using AutoInject;

namespace ScopedItems
{
    public class ScopedItem : IAutoInjectScoped { }

    public class ScopedItemInstance : IAutoInjectScoped<IScopedItem> { }

    public interface IScopedItem { }
}
