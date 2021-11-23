using System;

namespace CSharpOOp
{//public,private->access modifier
        
    public class Animal//clasa de baza
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
        public Animal(string name,string color)
        {
            this.name = name;
        }
        //Getter
        public virtual string GetName()//daca metoda e virtual poate fi suprascrisa 
        {
            if(name.Contains("o"))
            {
                name = name.Replace(oldValue: "o", newValue:"a");
            }
            return name;
        }
        //Setter
        public void SetName(string name)
        {
            this.name=name.ToLower();
        }
    }

    public class Cat : Animal//clasa derivata
    {
        public Cat(string name) : base(name)
        {
            
        }

        public override string GetName()
        {
            var baseName = base.GetName();
            return baseName + "The Cat";
        }
    }

    public class Mouse : Animal//clasa derivata
    {
        public Mouse(string name) : base(name){}

        public override string GetName()
        {
            return base.GetName()+"The Mouse";
        }
    }
}