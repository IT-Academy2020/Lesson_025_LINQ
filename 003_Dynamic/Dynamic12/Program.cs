using System;

// Динамічні типи даних.

namespace Dynamic
{
    class MyClass
    {

    }

    class Program
    {
        static dynamic FactoryMethod()
        {
            return new MyClass();
        }

        static void Main()
        {
            dynamic instance = FactoryMethod() as dynamic;

            if (false)
            {
                instance.Method(7); // Виклик методу.
                instance.field = instance.Property; // Як отримати та інсталювати значень полів і властивостей.
                instance["one"] = instance[2]; // Як отримати та інсталювати значень через індексатори.
                dynamic variable = instance + 3; // Виклик операторів.
                variable = instance(5, 7); // Виклик делегатів.
            }

            // Delay.
            Console.ReadKey();
        }
    }
}