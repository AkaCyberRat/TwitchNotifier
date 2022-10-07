using App.Domain.NotifierService.Models;

namespace App.Domain.NotifierService
{
    public interface IStreamObserver
    {
        void Update(StreamState state);
        string GetId();
        Pattern GetPattern();
        Context GetContext();
    }
}
