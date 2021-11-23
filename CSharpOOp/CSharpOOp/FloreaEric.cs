using System;

namespace CSharpOOp
{
    //public, private -> access modifiers
    public class Animal
    {
        private string name; //atribut / field

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