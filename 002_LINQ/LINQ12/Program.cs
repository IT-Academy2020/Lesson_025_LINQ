using System;
using System.Collections.Generic;
using System.Linq;

// let - представляє новий локальний ідентифікатор, на який можна посилатися в іншій частині запиту.
// Його можна уявити, як локальну змінну видиму тільки всередині виразу запиту.

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            // Побудувати запит.
            var query = from x in Enumerable.Range(0, 10)
                        let innerRange = Enumerable.Range(0, 10)
                        from y in innerRange
                        select new { X = x, Y = y, Product = x * y };

            foreach (var item in query)
                Console.WriteLine("{0} * {1} = {2}", item.X, item.Y, item.Product);

            // Delay.
            Console.ReadKey();
        }
    }
}