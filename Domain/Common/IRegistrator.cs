namespace Domain.Common
{
    public interface IRegistrator<TRegistrable>
    {
        void Register(TRegistrable registrable);
    }
}
