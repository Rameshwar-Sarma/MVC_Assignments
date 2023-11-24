using Newtonsoft.Json;

namespace EmployeesWebApplication.Models { 

    /// <summary>
    /// Factory class of IEmployeeRepo interface.
    /// </summary>
    public class EmployeeRepo : IEmployeeRepo
    {
        public IEnumerable<Employee>? GetEmployeeById(int? EmployeeId)
        {
            List<Employee>? employees = new List<Employee>();
            JsonReader readObj  = new JsonReader();
            employees = JsonConvert.DeserializeObject<List<Employee>>(readObj.Read("Employees.json"));
            var result = from employee in employees
                         where employee.ID == EmployeeId
                         select employee;

            if(result.Count<Employee>() == 1)
            {
                return result;
            }
            else
            {
                return employees;
            }
        }
    }
}
