using App.Domain.Common;
using System.Threading.Tasks;

namespace App.Domain.ShellService
{
    public interface IShell : IRegistrator<ICommand>
    {
        Task<string> ExecuteCommand(ICommand command);

        ICommand GetCommandByName(string name);
    }
}
