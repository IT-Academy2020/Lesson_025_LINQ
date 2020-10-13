using System;

// Динамічні типи даних. (Динамічні типи аргументів і значень методів.)

namespace Dynamic
{
    class Program
    {
        static dynamic Method(dynamic argument)
        {
            return "Hello" + argument + "!";
        }

        static void Main()
        {
            string @string = Method("friend");

            Console.WriteLine(@string);

            // Delay.
            Console.ReadKey();
        }
    }
}