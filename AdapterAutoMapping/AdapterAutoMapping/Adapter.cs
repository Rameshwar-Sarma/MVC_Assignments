
namespace AdapterAutoMapping
{
    public class Adapter : IAdapter<Employee, Person>
    {
        Person IAdapter<Employee, Person>.GetPerson(Employee employee)
        {
            Person personObj = new Person();
            personObj.Id = employee.Id;
            personObj.Name = employee.Name;
            personObj.City = employee.Address.City;
            personObj.State = employee.Address.State;
            personObj.PostalCode = employee.Address.PostalCode;
            return personObj;
        }
    }
}
