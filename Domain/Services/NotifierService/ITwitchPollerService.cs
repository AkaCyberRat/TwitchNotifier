using System.Threading.Tasks;

namespace Domain.Services.NotifierService
{
    public interface ITwitchPollerService
    {
        Task<StreamState[]> GetStreamStates(string[] usernames);
    }
}
