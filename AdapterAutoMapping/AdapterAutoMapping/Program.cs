using System;
using System.Collections.Generic;

namespace AdapterAutoMapping
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee empObj = new Employee()
            {
                Id = 250,
                Name = "Rameshwara Sarma",
                Address = new Address()
                {
                    City = "Hyderabad",
                    State = "Telangana",
                    PostalCode = "500092"
                }
            };
            IAdapter<Employee, Person> adapterObj = new Adapter();
            Person personObj = adapterObj.GetPerson(empObj);
            Console.WriteLine(personObj.Id + " " + personObj.Name);
            Console.ReadLine();

        }
    }
}
