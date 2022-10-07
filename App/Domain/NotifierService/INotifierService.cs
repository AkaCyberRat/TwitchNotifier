using App.Domain.NotifierService.Models;
using System.Threading.Tasks;

namespace App.Domain.NotifierService
{
    public interface INotifierService
    {
        Task StartNotifier();
        Task StopNotifier();

        Task AddStreamObserver(Pattern pattern);
        Task RemoveStreamObserver(string id);

        Task<IStreamObserver> GetStreamObserver(string id);
        Task<IStreamObserver[]> GetStreamObservers();
    }
}
