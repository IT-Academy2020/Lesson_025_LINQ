using System;
using System.Collections.Generic;
using System.Linq;

// join (операція об'єднання) - встановлює співвідношення даних з двох різних джерел.

namespace LINQ
{
    public class EmployeeID
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class EmployeeNationality
    {
        public string Id { get; set; }
        public string Nationality { get; set; }
    }

    class Program
    {
        static void Main()
        {
            // Побудувати колекцію співробітників.
            var employees = new List<EmployeeID>
            {
                new EmployeeID {Id = "111", Name = "Ivan Ivanov"},
                new EmployeeID {Id = "222", Name = "Andrey Andreev"},
                new EmployeeID {Id = "333", Name = "Petr Petrov"},
                new EmployeeID {Id = "444", Name = "Alex Alexeev"}
            };

            // Побудувати колекцію національностей.
            var empNationalities = new List<EmployeeNationality>
            {
                new EmployeeNationality {Id = "111", Nationality = "Russian"},
                new EmployeeNationality {Id = "222", Nationality = "Ukrainian"},
                new EmployeeNationality {Id = "333", Nationality = "American"},
            };

            // Побудувати запит.
            // Отримання списку імен всіх співробітників разом з їх національностями, при цьому відсортувавши список по спаданню.
            var query = from emp in employees
                        join n in empNationalities
                        on emp.Id equals n.Id
                        orderby n.Nationality descending // ascending - по зростанню | descending - по спаданню.
                        select new
                        {
                            Id = emp.Id,
                            Name = emp.Name,
                            Nationality = n.Nationality
                        };

            foreach (var person in query)
                Console.WriteLine("{0}, {1}, \t {2}", person.Id, person.Name, person.Nationality);

            // Delay.
            Console.ReadKey();
        }
    }
}