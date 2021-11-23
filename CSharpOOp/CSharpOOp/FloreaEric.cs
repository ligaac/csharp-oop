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
	    // functie = primeste un numar de argumente si returneaza ceva inapoi
	    // metoda = acelasi lucru cu functia dar putem accesa orice variabila

	    //Getter
	    //virtual -> metoda poate fi suprascris in clasa derivata
	    public virtual string GetName()
	    {
		    if (name.Contains("o"))
		    {
			    name = name.Replace(oldValue: "o", newValue: "a");
		    }

		    return name;
	    }

	    //Setter
	    public void SetName(string name)
	    {
		    this.name = name.ToLower();
	    }

	    
	    
}
    //mostenire
    //clasa derivata
    public class Cat : Animal
    {
	    public Cat(string name) : base(name){}

	    public override string GetName()
	    {
		    var baseName = base.GetName();
		    return baseName + " The Cat";
	    }
		    
    }

    public class Mouse : Animal
    {
	    public Mouse(string name) : base(name){}

	    public override string GetName()
	    {
		    var baseName = base.GetName();
		    return baseName + " The Mouse";
	    }
		    
    }
}