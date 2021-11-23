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

            var animal1 = cat as Animal;
            var animal2 = mouse as Animal;
            Console.WriteLine(animal1.GetName()); //"Tam the cat"

            Animal[] myList = new[] {animal1, animal2};

            foreach (var animal in myList)
            {
                if (animal.GetType() == typeof(Cat))
                {
                    Console.WriteLine("Is Cat");
                }
                else
                {
                    Console.WriteLine("Is Mouse");
                }
                
            }
        }
    }
}