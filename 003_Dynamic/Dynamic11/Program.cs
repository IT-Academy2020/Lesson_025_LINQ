using System;

// Динамічні типи даних. (Наслідування)

namespace Dynamic
{
    class Base
    {
        public dynamic field;

        public dynamic Method()
        {
            return this.field;
        }
    }

    class Derived : Base
    {

    }

    class Program
    {
        static void Main()
        {
            dynamic instance = new Derived();

            // Динамічні поля повинні бути проініціалізірованни перед використанням.
            instance.field = "Hello";

            Console.WriteLine(instance.Method());

            // Delay.
            Console.ReadKey();
        }
    }
}