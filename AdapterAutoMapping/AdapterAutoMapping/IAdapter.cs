
namespace AdapterAutoMapping
{
    public interface IAdapter<T,P>
    {
        P GetPerson(T employee);
    }
}
