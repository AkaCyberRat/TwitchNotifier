using App.Domain.Common;

namespace App.Domain.NotifierService
{
    internal interface IFormatterRegistry : IRegistrator<IFormatter>
    {
        IFormatter GetFormatter(string name);
        IFormatter GetDefaultFormatter();
    }
}
