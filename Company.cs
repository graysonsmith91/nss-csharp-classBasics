using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {

        public Company(string name, DateTime date)
        {
            Name = name;
            CreatedOn = date;
            Employees = new List<Employee>();
        }

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees { get; set; }

        public void ListEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName}{employee.LastName} works for {Name} as a {employee.Title} since {employee.StartDate}");
            }
        }
    }
}