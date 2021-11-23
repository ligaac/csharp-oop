using System;

namespace CSharpOOp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int, float, char, etc, etc -> tipuri primitive
            Cat cat = new Cat("Tom");
            Mouse mouse = new Mouse("Jerry");
            //animal este o instanta a clasei Animal
           
            Console.WriteLine(cat.GetName());
            Console.WriteLine(mouse.GetName());
        }
    }
}