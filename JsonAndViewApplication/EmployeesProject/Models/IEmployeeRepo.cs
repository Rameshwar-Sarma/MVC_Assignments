namespace EmployeesWebApplication.Models
{
    public interface IEmployeeRepo
    {
        IEnumerable<Employee>? GetEmployeeById(int? Id);
    }
}
