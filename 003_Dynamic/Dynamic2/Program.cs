using System;

// Динамічні типи даних. (Статичні поля)

namespace Dynamic
{
    class Program
    {
        static dynamic field = 1;

        static void Main()
        {
            Console.WriteLine(field);

            field = "Hello world!";

            Console.WriteLine(field);

            field = DateTime.Now;

            Console.WriteLine(field);

            // Delay.
            Console.ReadKey();
        }
    }
}