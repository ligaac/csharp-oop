using System;

namespace CSharpOOp
{
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

        //getter
        public virtual string GetName()
        {
            if (name.Contains("o"))
            {
                return name.Replace("o", "a");
            }

            return name;
        }

        //setter
        public void SetName(string name)
        {
            this.name = name.ToLower();
            
        }

    }

    //mostenire
        public class Cat : Animal
        {
            public Cat(string name) : base(name)
            {
                
            }

            public override string GetName()
            {
                var baseName = base.GetName();
                return baseName + " The Cat ";
            }
        }
        
        public class Mouse : Animal
        {
            public Mouse(string name): base(name){}
            
            public override string GetName()
            {
                var baseName = base.GetName();
                return baseName + " The Mouse ";
            }
        }
        
        
    }
