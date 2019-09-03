using System;
using System.Collections.Generic;
using System.Text;

namespace Corporate_Class
{
    class Company
    {
        public string CompanyName { get; }
        public DateTime CreatedOn { get; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public Company(string companyName, DateTime createdOn)
        {
            CompanyName = companyName;
            CreatedOn = createdOn;
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
        public void RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }
        public void ListEmployees()
        {
            foreach (var employee in Employees)
            {
                Console.WriteLine(employee.Name);
            }
        }
    }
}
