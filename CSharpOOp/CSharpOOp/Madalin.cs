using System;

namespace CsharpOOp
{
    //public,private ->access modifiers
    public class Animal
    {
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