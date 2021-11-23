namespace CSharpOOp
{
    // public, private -> access modifier
    public class Animal
    {
        // atribut / filed
        public string name;

        public Animal(string name) // constructor
        {
            this.name = name;
        }

        public string getName() // getter
        {
            return this.name;
        }
    }
}