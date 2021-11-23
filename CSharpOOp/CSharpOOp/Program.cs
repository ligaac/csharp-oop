using System;

namespace CSharpOOp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //int, float, char, etc, etc -> tipuri primitive
            Animal animal = new Animal();
            //animal este o instanta a clasei Animal
            animal.name = "some animal here";
            Console.WriteLine(animal.name);
        }
    }
}