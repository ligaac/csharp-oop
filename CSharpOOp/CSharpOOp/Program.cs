using System;
using System.ComponentModel.Design;
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
            var animal1 = cat as Animal;
            var animal2 = mouse as Animal;
            // doesn't work Animal[] mylist = new[] {cat, mouse};
            Animal[] myList = new[] {animal1, animal2};
            Console.WriteLine(animal1.GetName());
            
            foreach (var animal in myList)
            {
                if(animal.GetType()== typeof(Cat)) 
                    //if (animal is Cat)
                {
                    Console.WriteLine("Is cat");
                }
                else
                {
                    Console.WriteLine(("Is mouse"));
                }
            }
            
            Console.WriteLine(animal1.GetName());
        // OOP building blocks:
            //Mostenire
            //polimorfism
            //incapsulare(sa folosesti private)
            //abstractizare
        }
    }
}