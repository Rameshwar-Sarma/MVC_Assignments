using System;
using System.Collections.Generic;

namespace AdapterAutoMapping
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }

    }
    public class Address
    {
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
    }
}
