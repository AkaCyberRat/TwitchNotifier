using System.Threading.Tasks;

namespace App.Domain.ShellService
{
    public interface ICommand
    {
        Task<string> ExecuteAsync();
    }
}
