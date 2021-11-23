using System;

namespace CSharpOOp
{
    
    class Program
    {
        static void Main(string[] args)
        {   //int float char etc ect ->tipuri primitive;
            int x = 3;
            //animal este o instanta a clasei Animal
            Cat cat = new Cat(name:"Tom");
            Mouse mouse = new Mouse(name: "Jerry");
            var animal1 = cat as Animal;
            var animal2 = mouse as Animal;
            Animal[] myList = new[] {animal1, animal2};
            foreach (var animal in myList)
            {   if(animal is Cat)
                //if (animal.GetType() == typeof(Cat))
                {
                    Console.WriteLine("IS CAT");
                    
                }
                else
                {
                    Console.WriteLine("is mouse");
                }
            }
            Console.WriteLine(cat.GetName());
            //cat.SetName("Another Tom");
          //  Console.WriteLine(cat.GetName());
            Console.WriteLine(mouse.GetName());
            //OOP building block:
            //polimorfism
            //mostenire
            //incapsulare
            //abstractizare
        }
    }
}