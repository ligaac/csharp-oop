using System;

namespace CSharpOOp
{
    // public, private -> access modifier
    public class Animal
    {
        // atribut / filed
        private string name;

        public Animal()
        {
            Console.WriteLine("Create animal!");
        }

        public Animal(string name) // constructor
        {
            this.name = name;
        }

        // virtual -> poate fi suprascris din derivate
        public virtual string getName() // getter
        {
            // hidden functionality
            if (this.name.Contains('N'))
            {
                return this.name.Replace('N', 'P');
            }
            return this.name;
        }

        public virtual void setName(string name) //setter
        {
            this.name = name;
        }
    }

    public class Cat : Animal
    {
        public Cat(string name) : base(name) {}

        public override string getName()
        {
            var baseName = base.getName();
            return baseName + " the Cat";
        }
    }

    public class Mouse : Animal
    {
        public Mouse(string name) : base(name) {}
        
        public override string getName()
        {
            var baseName = base.getName();
            return baseName + " the Mouse";
        }
    }
}