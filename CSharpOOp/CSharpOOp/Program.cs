using System;

namespace CSharpOOp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int float char
            int x = 3;
            
            Cat cat = new Cat("Tom");
            Mouse mouse = new Mouse("Jerry");
            
            Console.WriteLine(cat.GetName());
            Console.WriteLine(mouse.GetName());

            
        }
    }
    
    //OOP building blocks
    //-polimorfism
    //-mostenire
    //-incapsulare
    //-abstractizare
}