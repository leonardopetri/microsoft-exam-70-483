using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new ConstructorChainning());
            Console.WriteLine(new ConstructorChainning(2));
        }
    }

    public class ConstructorChainning
    {
        private int p;

        public ConstructorChainning() : this(3)
        { }

        public ConstructorChainning(int a)
        {
            p = a;
        }

        public override string ToString()
        {
            return $"{p}";
        } 
    }
}
