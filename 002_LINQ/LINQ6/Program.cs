using System;
using System.Collections;
using System.Linq;

// Застосування запиту до колекції яка підтримує IEnumerable НЕ параметризованих.

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            ArrayList numbers = new ArrayList();
            numbers.Add(1);
            numbers.Add(2);

            // ЯВНА вказівка типу Int32 змінної - n. (Var - НЕМОЖЛИВО використовувати тому що IEnumerable НЕ параметризований!)
            var query = from int n in numbers
                        select n * 2;

            foreach (var item in query)
                Console.WriteLine(item);

            // Delay.
            Console.ReadKey();
        }
    }
}