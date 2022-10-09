using Domain.Common;

namespace Domain.Services.NotifierService
{
    internal interface IFormatterRegistry : IRegistrator<IFormatter>
    {
        IFormatter GetFormatter(string name);
        IFormatter GetDefaultFormatter();
    }
}
