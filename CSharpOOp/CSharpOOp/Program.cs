using System;

namespace CSharpOOp
{
    
    class Program
    {
        static void Main(string[] args)
        {   //int float char etc ect ->tipuri primitive;
            int x = 3;
            //animal este o instanta a clasei Animal
            Animal animal = new Animal(name:"Tom");
            Animal mouse = new Animal(name: "Jerrry");
            Console.WriteLine(animal.GetName());
        }
    }
}