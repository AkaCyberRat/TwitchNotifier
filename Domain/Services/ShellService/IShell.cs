using Domain.Common;
using System.Threading.Tasks;

namespace Domain.Services.ShellService
{
    public interface IShell : IRegistrator<ICommand>
    {
        Task<string> ExecuteCommand(ICommand command);

        ICommand GetCommandByName(string name);
    }
}
