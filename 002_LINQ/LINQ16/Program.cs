using System;
using System.Linq;

// into - подібно let, дозволяє визначити локальний по відношенню до запиту ідентифікатор.

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Побудувати запит.
            // Поділ чисел на парні і непарні.
            var query = from x in numbers
                        group x by x % 2 into partition
                        select new { Key = partition.Key, Count = partition.Count(), Group = partition };


            foreach (var item in query)
            {
                Console.WriteLine("mod2 == {0}", item.Key);
                Console.WriteLine("Count == {0}", item.Count);

                foreach (var number in item.Group)
                    Console.Write("{0},", number);

                Console.WriteLine("\ n");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}