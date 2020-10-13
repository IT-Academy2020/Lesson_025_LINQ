using System;

// Анонімні типи.

// Анонімні типи пропонують зручний спосіб створення об'єкту з набором властивостей
// без необхідності попереднього явного визначення типу.
// Ім'я типу створюється компілятором і недоступно на рівні вихідного коду.
// Анонімні типи є reference типами, які наслідуються безпосередньо від класу object.
// Компілятор надає їм імена, незважаючи на те що ці імена недоступні для додатку.

namespace Anonymous
{
    class Program
    {
        static void Main()
        {
            var instance = new { Name = "Alex", Age = 27 };

            Console.WriteLine("Name = {0}, Age = {1}", instance.Name, instance.Age);

            Type type = instance.GetType();

            Console.WriteLine(type.ToString());

            // Delay.
            Console.ReadKey();
        }
    }
}