using System;

namespace CSharpOOp
{
    class Program
    {
        static void Main(string[] args)
        {
            // animal este o instanta a clasei Animal
            Animal animal = new Animal();
            Console.WriteLine(animal.GetName());
        }
    }
}