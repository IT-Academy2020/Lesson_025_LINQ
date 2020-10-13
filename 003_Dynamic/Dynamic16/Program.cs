using System;

// Динамічні типи даних.

namespace Dynamic
{
    class Calculator
    {
        public dynamic Add(dynamic a, dynamic b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main()
        {
            dynamic calculator = new Calculator();

            Console.WriteLine(calculator.Add(2, 3));
            Console.WriteLine(calculator.Add("1", 2));

            // Delay.
            Console.ReadKey();
        }
    }
}