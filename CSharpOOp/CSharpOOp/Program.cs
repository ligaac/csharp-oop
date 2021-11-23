using System;

namespace CSharpOOp
{
    class Program
    {
        static void Main(string[] args)
        {
            // int, float, char, etc, etc -> tipuri primitive;
            int x = 3;

            // animal este o instanță a clasei Animal
            Cat cat = new Cat("Tom");
            Mouse mouse = new Mouse("Jerry");

            Console.WriteLine(cat.GetName());
            // animal.SetName("Another Tom");
            // Console.WriteLine(animal.GetName());
            Console.WriteLine(mouse.GetName());

            var animal1 = cat as Animal;
            var animal2 = mouse as Animal;
            Animal[] myList = new[] { animal1, animal2 };
            foreach (var animal in myList)
            {
                if (animal is Cat)
                {
                    Console.WriteLine("Is cat");
                }
                else
                {
                    Console.WriteLine("is mouse");
                }
            }
            Console.WriteLine(animal1.GetName());

            // OOP building blocks:
            // - polimorfism
            // - moștenire
            // - încapsulare
            // - abstractizare
        }
    }
}
