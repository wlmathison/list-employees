using System;
using System.Collections.Generic;

namespace list_employees
{
    public class Company
    {
        public Company(string name, DateTime date)
        {
            Name = name;
            CreatedOn = date;
        }

        public string Name { get; }
        public DateTime CreatedOn { get; }

        public List<Employee> Employees = new List<Employee>();

        public void AssignEmployee(Employee employee) {
            Employees.Add(employee);
        }

        public void ListEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FullName} works for {Name} as a {employee.Title} since {employee.StartDate.ToShortDateString()}.");
            }
        }
    }
}