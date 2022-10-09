namespace Domain.Services.NotifierService
{
    public interface IFormatter
    {
        string GetName();
        string Format(Context context);
    }
}
