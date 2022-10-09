using System.Threading.Tasks;

namespace Domain.Services.NotifierService
{
    public interface INotifier
    {
        string GetTags();
        Task Notify(Context context);
    }
}
