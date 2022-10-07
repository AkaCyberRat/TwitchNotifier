using App.Domain.NotifierService.Models;

namespace App.Domain.NotifierService
{
    public interface IFormatter
    {
        string GetName();
        string Format(Context context);
    }
}
