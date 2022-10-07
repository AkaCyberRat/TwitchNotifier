using App.Domain.NotifierService.Models;
using System.Threading.Tasks;

namespace App.Domain.NotifierService
{
    public interface INotifier
    {
        string GetTags();
        Task Notify(Context context);
    }
}
