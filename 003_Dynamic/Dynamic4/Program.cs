using System;

// Динамічні типи даних.

namespace Dynamic
{
    class Program
    {
        static void Main()
        {
            for (dynamic i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello world!");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}