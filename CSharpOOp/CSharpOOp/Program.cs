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
            Cat cat = new Cat("CatName");
            Mouse mouse = new Mouse("MouseName");
            Console.WriteLine(cat.getName());
            // cat.setName("NewCatName");
            // Console.WriteLine(cat.getName());
            Console.WriteLine(mouse.getName());
        }
    }
    
    /*
     * OOP building blocks:
     * - incapsulare => hide vars
     * - abstractizare => hide functionality
     * - polimorfism
     * - mostenire
     */
}