using Domain.Common;

namespace Domain.Services.NotifierService
{
    public interface INotifierRegistry : IRegistrator<INotifier>
    {
        INotifier[] GetNotifiers(string[] tags);
    }
}
