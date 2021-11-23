using System;

namespace CSharpOOp
{
    // public, private -> access modifiers
    public class Animal
    {
        // atribut / field
        private string name;

        public Animal()
        {
            Console.WriteLine("Create animal");
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
