using System;

namespace Corporate_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            var abcCo = new Company("abc company", DateTime.Now);
            var employee1 = new Employee("joe", "janitor", DateTime.Now);
            var employee2 = new Employee("chuck", "cashier", DateTime.Now);
            var employee3 = new Employee("doug", "barber", DateTime.Now);
            var employee4 = new Employee("mark", "shepard", DateTime.Now);
            var employee5 = new Employee("peter", "public speaker", DateTime.Now);

            abcCo.AddEmployee(employee1);
            abcCo.AddEmployee(employee2);
            abcCo.AddEmployee(employee3);
            abcCo.AddEmployee(employee4);
            abcCo.AddEmployee(employee5);

            abcCo.RemoveEmployee(employee2);
            abcCo.ListEmployees();

            employee1.Eat();
            employee1.Eat("enchiladas");
            employee1.Eat(abcCo.Employees);
            employee1.Eat(abcCo.Employees, "tacos");
        }
    }
}
