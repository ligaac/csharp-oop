using System;

namespace CSharpOOp
{
    class Program
    {
        static void Main(string[] args)
        {
            // animal este o instanta a clasei Animal
            Cat cat = new Cat(name:"Tom");
            Mouse mouse = new Mouse(name: "Jerry");
            
            Console.WriteLine(cat.GetName());
            cat.SetName("Another Tom");
            //Console.WriteLine(animal.GetName());
            Console.WriteLine(mouse.GetName());
            
            // OOP building block;
            // polimorfism
            // mostenire // 
            // incapsulare
            // abstractizare
        }
    }
}