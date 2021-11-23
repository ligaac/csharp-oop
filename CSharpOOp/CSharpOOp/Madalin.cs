using System;

namespace CsharpOOp
{
    //public,private ->access modifiers
    public class Animal
    {
        private string name;
      //clasa de baza
        public Animal()
                 {
                     Console.WriteLine("Create animal");
                 }
        
        public Animal(string name)
        {
            this.name = name;
        }
        
        //Getter
        public virtual string GetName()
        {

            if (name.Contains("o"))
            {
                return name.Replace("o", "a");
            }

            return name;
        }
        
        //Setter
        public void SetName(string name)
        {
            this.name=name.ToLower();
        }
    
    }
     //mostenire
     //clasa derivata
     //virtual => metoda poate fi suprascrica in clasa derivata
    public class Cat : Animal
    {
     
        public Cat(string name) :base(name){} 
        public override string GetName()
        {
            var baseName = base.GetName();
            return baseName + " The Cat";
        }
    }
    

    public class Mouse : Animal
    {
        public Mouse(string name) :base(name){}
        public override string GetName()
        {
            return base.GetName() + " The Mouse";
        }
    }

}