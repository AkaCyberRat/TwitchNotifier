using System.Threading.Tasks;

namespace Domain.Services.ShellService
{
    public interface ICommand
    {
        Task<string> ExecuteAsync();
    }
}
