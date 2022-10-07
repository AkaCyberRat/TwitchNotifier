using System.Threading.Tasks;

namespace App.Domain.ShellService
{
    public interface IShellService
    {
        Task StartShell();
        Task StopShell();
        Task<string> ExecuteCommand(string commandName);
    }
}
