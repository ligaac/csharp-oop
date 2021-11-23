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
            Animal anim1 = cat as Animal;
            Animal anim2 = mouse as Animal;
            Animal[] animList = new[] { anim1, anim2 };
            foreach (var animal in animList)
            {
                if (animal is Cat)
                {
                    Console.WriteLine("Is cat");
                }
                else
                {
                    Console.WriteLine(("Is Mouse"));
                }
            }
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