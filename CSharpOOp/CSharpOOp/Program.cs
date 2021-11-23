using System;

namespace CSharpOOp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int , float , char ,etc -> tipuri primitive
            int x = 3;
            
            //animal e o instanta a clasei Animal
            Animal animal = new Animal("Tom");
            Animal mouse = new Animal("Jerry");
            Console.WriteLine(animal.GetName());
            Console.WriteLine(mouse.GetName());
        }
    }
}