using System;
using CsharpOOp;

namespace CSharpOOp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            //int,float,char ->date primitve 
            int x = 3;
            //animal este o instanta a clasei Animal
            Animal animal = new Animal();
            Animal mouse = new Animal("Jerry");
            Console.WriteLine(animal.GetName());
            Console.WriteLine(mouse.GetName());

        }
    }
}