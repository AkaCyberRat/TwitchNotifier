using App.Domain.Common;

namespace App.Domain.NotifierService
{
    public interface INotifierRegistry : IRegistrator<INotifier>
    {
        INotifier[] GetNotifiers(string[] tags);
    }
}
