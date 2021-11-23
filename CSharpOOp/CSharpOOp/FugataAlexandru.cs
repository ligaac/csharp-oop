using System;

namespace CSharpOOp
{//public,private->access modifier
        
    public class Animal
    { //atribut/field
        private string name;

        public Animal()
        {
            Console.WriteLine("Create Animal");
        }

        public Animal(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
    }
}