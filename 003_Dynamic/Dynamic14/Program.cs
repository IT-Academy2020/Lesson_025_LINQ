using System;

// Динамічні типи даних. (Динамічні типи аргументів і значень методів.)

namespace Dynamic
{
    class Program
    {
        static dynamic Method(ref dynamic argument1, out dynamic argument2)
        {
            argument1 = ++argument1;
            argument2 = 2;

            return default(dynamic);
        }

        static void Main()
        {
            dynamic variable1 = 0, variable2;

            Method(ref variable1, out variable2);

            Console.WriteLine(variable1);
            Console.WriteLine(variable2);

            // Delay.
            Console.ReadKey();
        }
    }
}