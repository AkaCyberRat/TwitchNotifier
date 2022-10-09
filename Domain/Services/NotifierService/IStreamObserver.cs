namespace Domain.Services.NotifierService
{
    public interface IStreamObserver
    {
        void Update(StreamState state);
        string GetId();
        Pattern GetPattern();
        Context GetContext();
    }
}
