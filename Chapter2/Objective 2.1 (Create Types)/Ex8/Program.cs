using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance = new MyClass<Dummie>();
            Console.WriteLine(instance.Value.Value);
        }
    }

    public class MyClass<T> where T : class, new()
    {
        public T Value { get; private set; }
        public MyClass()
        {
            Value = new T();
        }
    }

    public class Dummie
    {
        public string Value { get; set; } = "Valor";
    }
}
