using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company company = new Company("Phony's", DateTime.Now);

            // Create three employees
            Employee employee1 = new Employee
            {
                FirstName = "Phony",
                LastName = "McPhony",
                Title = "CEO",
                StartDate = DateTime.Now
            };

            Employee employee2 = new Employee
            {
                FirstName = "George",
                LastName = "Jones",
                Title = "Janitor",
                StartDate = DateTime.Now
            };

            Employee employee3 = new Employee
            {
                FirstName = "Grayson",
                LastName = "Smith",
                Title = "Manager",
                StartDate = DateTime.Now
            };


            // Assign the employees to the company
            company.Employees.Add(employee1);
            company.Employees.Add(employee2);
            company.Employees.Add(employee3);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            company.ListEmployees();
        }
    }
}