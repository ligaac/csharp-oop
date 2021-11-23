using System;

namespace CSharpOOp
{
    // public, private -> access modifiers
    // clasă de bază
    public class Animal
    {
        // atribut / field
        private string name;
        public string type;

        // public Animal()
        // {
        //     Console.WriteLine("Create animal");
        // }

        public Animal(string name)
        {
            this.name = name;
        }

        public Animal(string name, string color)
        {
            this.name = name;
        }

        // Getter
        // virtual => metoda poate fi suprascrisă în clasa
        // derivată
        public virtual string GetName()
        {
            if (name.Contains("o"))
            {
                return name.Replace("o", "a");
            }
            return name;
        }

        // Setter
        public void SetName(string name)
        {
            this.name = name.ToLower();
        }
    }

    // moștenire
    // clasă derivată
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override string GetName()
        {
            var baseName = base.GetName();
            return baseName + " The Cat";
        }
    }

    public class Mouse : Animal
    {
        public Mouse(string name): base(name){}

        public override string GetName()
        {
            return base.GetName() + " The Mouse";
        }
    }
}
