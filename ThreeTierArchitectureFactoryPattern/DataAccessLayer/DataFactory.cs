
namespace DataAccessLayer
{
    public class DataFactory : IDataFactory
    {
        public IDataAccess GetDataAccess()
        {
            return new DataAccess();
        }
    }
}
