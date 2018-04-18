using System;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("int: "+MyGenericMethod<int>());
            Console.WriteLine("string: " + MyGenericMethod<string>());
            Console.WriteLine("datetime: " + MyGenericMethod<DateTime>());
            Console.WriteLine("object: " + MyGenericMethod<Object>());
        }

        public static T MyGenericMethod<T>()
        {
            return default(T);
        }
    }
}
