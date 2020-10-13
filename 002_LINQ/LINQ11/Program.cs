using System;
using System.Collections.Generic;
using System.Linq;

// let - представляє новий локальний ідентифікатор, на який можна посилатися в іншій частині запиту.
// Його можна уявити, як локальну змінну видиму тільки всередині виразу запиту.

namespace LINQ
{
    public class Employee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }

    class Program
    {
        static void Main()
        {
            // Побудувати колекцію співробітників.
            var employees = new List<Employee>
            {
                new Employee {LastName = "Ivanov", FirstName = "Ivan"},
                new Employee {LastName = "Andreev", FirstName = "Andrew"},
                new Employee {LastName = "Petrov", FirstName = "Petr"}
            };

            // Побудувати запит.
            var query = from emp in employees
                        let fullName = emp.FirstName + "" + emp.LastName // let - новий локальний ідентифікатор.
                        orderby fullName descending
                        select fullName;

            foreach (var person in query)
                Console.WriteLine(person);

            // Delay.
            Console.ReadKey();
        }
    }
}