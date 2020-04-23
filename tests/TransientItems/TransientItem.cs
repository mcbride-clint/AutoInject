using AutoInject;

namespace TransientItems
{
    public class TransientItem : IAutoInjectTransient { }

    public class TransienttemInstance : IAutoInjectTransient<ITransientItem> { }

    public interface ITransientItem { }
}
