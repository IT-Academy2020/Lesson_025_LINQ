using System;

// Динамічні типи даних. (Динамічні типи в параметризованих делегатів)

namespace Dynamic
{
    delegate R MyDelegate<T, R>(T argument);

    class Program
    {
        static dynamic Method(dynamic argument)
        {
            return argument;
        }

        static void Main()
        {
            dynamic myDelegate = new MyDelegate<dynamic, dynamic>(Method);

            dynamic @string = myDelegate("Hello world!");

            Console.WriteLine(@string);

            // Delay.
            Console.ReadKey();
        }
    }
}