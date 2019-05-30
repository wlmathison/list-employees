using System;

namespace list_employees
{
    public class Employee
    {
        public Employee(string firstName, string lastName, string title, int year, int month, int day) {
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            StartDate = new DateTime(year, month, day);
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

    }
}