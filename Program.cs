using System;

namespace list_employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Company Acme = new Company("Acme, Inc.", DateTime.Now);

            Employee JohnRambo = new Employee("John", "Rambo", "Soldier", 1982, 10, 22);
            Employee JohnMcClane = new Employee("John", "McClane", "Police Officer", 1988, 7, 15);
            Employee JohnWick = new Employee("John", "Wick", "Hitman", 2014, 10, 24);

            Acme.AssignEmployee(JohnRambo);
            Acme.AssignEmployee(JohnMcClane);
            Acme.AssignEmployee(JohnWick);

            Acme.ListEmployees();
        }
    }
}
