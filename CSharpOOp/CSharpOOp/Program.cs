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

            // OOP building blocks:
            // - polimorfism
            // - moștenire
            // - încapsulare
            // - abstractizare
        }
    }
}
