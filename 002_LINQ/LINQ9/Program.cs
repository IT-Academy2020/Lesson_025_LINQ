using System;
using System.Collections.Generic;
using System.Linq;

// select - (Операція проекції) використовується для створення кінцевого результату запиту.

namespace LINQ
{
    public class Result
    {
        public Result(int input, int output)
        {
            Input = input;
            Output = output;
        }

        public int Input { get; set; }
        public int Output { get; set; }
    }

    class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4 };

            // Побудувати запит.
            var query = from x in numbers
                        select new Result(x, x * 2);

            numbers[0] = 777; // Вираз запиту виконується в момент звернення до змінної запиту в foreach.

            foreach (var item in query)
                Console.WriteLine("Input = {0}, \t Output = {1}", item.Input, item.Output);

            // Delay.
            Console.ReadKey();
        }
    }
}