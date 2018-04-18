using System;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base(3);
            Console.WriteLine($"Base.MyMethod(): {b.Method1()}");
            Console.WriteLine($"Base.BaseValue: {b.BaseValue}");
            Derived d = new Derived(3, 4);
            Console.WriteLine($"Derived.MyMethod(): {d.Method1()}");
            Console.WriteLine($"Derived.BaseValue: {d.BaseValue}");
            Console.WriteLine($"Derived.DerivedValue: {d.DerivedValue}");
        }
    }

    public class Base
    {
        public int BaseValue { get; set; }

        public Base(int baseValue)
        {
            this.BaseValue = baseValue;
        }

        public virtual int Method1()
        {
            return 42;
        }
    }

    public class Derived : Base
    {
        public int DerivedValue { get; set; }

        public Derived(int baseValue, int derivedValue) : base(baseValue)
        {
            this.DerivedValue = derivedValue;
        }
    }
}
