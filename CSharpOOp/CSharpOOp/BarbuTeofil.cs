using System;

namespace CSharpOOp
{
    public class Animal
    {
        public string name;
        public string type;

        public Animal()
        {
            Console.WriteLine("Create Animal");
        }

        public Animal(string name)
        {
            this.name = name;
        }

        public Animal(string name, string color)
        {
            this.name = name;
        }

        public virtual string GetName()
        {
            if (name.Contains("o"))
            {
                return name = name.Replace("o", "a");
            }
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }

    public class Cat : Animal
    {
        public Cat(string name):base(name){}

        public override string GetName()
        {
            var baseName = base.GetName();
            return baseName + " The Cat";
        }
    }

    public class Mouse : Animal
    {
        public Mouse(string name):base(name){}
    }
}