using App.Domain.NotifierService.Models;
using System.Threading.Tasks;

namespace App.Domain.NotifierService
{
    public interface ITwitchPoller
    {
        Task<StreamState[]> GetStreamStates(string[] usernames);
    }
}
