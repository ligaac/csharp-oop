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
            
            Cat cat = new Cat("Tom");
            Mouse mouse = new Mouse("Jerry");
            Console.WriteLine(cat.GetName());
            Console.WriteLine(mouse.GetName());
            
            // OOP building blocks:
            //Mostenire
            //polimorfism
            //incapsulare(sa folosesti private)
            //abstractizare
        }
    }
}