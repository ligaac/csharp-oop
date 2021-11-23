using System;

namespace CSharpOOp
{
    class Program
    {
        static void Main(string[] args)
        {
            // int, char, float -> primitive;
            int a = 3;

            // animal, mouse -> instances
            Animal animal = new Animal("AnimalName");
            Animal mouse = new Animal("MouseName");
            Console.WriteLine(animal.getName());
            Console.WriteLine(mouse.getName());
        }
    }
}