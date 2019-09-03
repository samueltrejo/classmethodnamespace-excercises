using System;
using System.Collections.Generic;
using System.Text;

namespace Corporate_Class
{
    class Employee
    {
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }

        public List<string> _restaurants = new List<string> { "Demos", "Prince's", "El Rancho", "Baja Burrito" };

        public Employee(string name, string jobTitle, DateTime startDate)
        {
            Name = name;
            JobTitle = jobTitle;
            StartDate = startDate;
        }

        private int GetRandomInt()
        {
            Random randomInt = new Random();
            return randomInt.Next(0, 3);
        }
        private string GetEmployeeGroup(List<Employee> employees)
        {
            string employeeGroup = "";
            for (var i = 0; i < employees.Count; i++)
            {
                if (employees[i].Name == Name)
                {
                }
                else if (employeeGroup == "")
                {
                    employeeGroup += employees[i].Name;
                } else if (i == employees.Count - 1)
                {
                    employeeGroup += $", and {employees[i].Name}";
                } else
                {
                    employeeGroup += $", {employees[i].Name}";
                }
            }
            return employeeGroup;
        }
        public string Eat()
        {
            int randomInt = GetRandomInt();
            string randomRestaurant = _restaurants[randomInt];
            Console.WriteLine($"{Name} is eating at {randomRestaurant}");
            return randomRestaurant;
        }
        public void Eat(string food)
        {
            Console.WriteLine($"{Name} is eating {food}");
        }
        public void Eat(List<Employee> employees)
        {
            int randomInt = GetRandomInt();
            string randomRestaurant = _restaurants[randomInt];
            string employeeGroup = GetEmployeeGroup(employees);
            Console.WriteLine($"{Name} is eating at {randomRestaurant} with {employeeGroup}");
        }
        public void Eat(List<Employee> employees, string food)
        {
            int randomInt = GetRandomInt();
            string randomRestaurant = _restaurants[randomInt];
            string employeeGroup = GetEmployeeGroup(employees);
            Console.WriteLine($"{Name} ordered {food} from {randomRestaurant} with {employeeGroup}");
        }
    }
}
