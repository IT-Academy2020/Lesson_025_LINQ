using System;
using System.Collections.Generic;
using System.Linq;

// Таблиця множення.

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            // Конструкція from схожа на оператор foreach.
            // Використання декількох конструкцій from, аналогічно вкладеним операторам foreach.

            var query = from x in Enumerable.Range(1, 9) // Таблиця множення від 1 до 9.
                        from y in Enumerable.Range(1, 10)
                        select new
                        {
                            X = x,
                            Y = y,
                            Product = x * y
                        };

            foreach (var item in query)
                Console.WriteLine("{0} * {1} = {2}", item.X, item.Y, item.Product);

            // Delay.
            Console.ReadKey();
        }
    }
}