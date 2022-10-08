using App.Domain.NotifierService.Models;
using System.Threading.Tasks;

namespace App.Domain.NotifierService
{
    public interface ITwitchPollerService
    {
        Task<StreamState[]> GetStreamStates(string[] usernames);
    }
}
