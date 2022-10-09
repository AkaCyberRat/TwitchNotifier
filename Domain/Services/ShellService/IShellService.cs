using System.Threading.Tasks;

namespace Domain.Services.ShellService
{
    public interface IShellService
    {
        Task StartShell();
        Task StopShell();
        Task<string> ExecuteCommand(string commandName);
    }
}
