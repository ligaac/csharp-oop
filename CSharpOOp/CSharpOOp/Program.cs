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
            Animal animal = new Animal("Tom");
            Animal mouse = new Animal("Jerry");
            Console.WriteLine(animal.GetName());
            Console.WriteLine(mouse.GetName());
        }
    }
}
