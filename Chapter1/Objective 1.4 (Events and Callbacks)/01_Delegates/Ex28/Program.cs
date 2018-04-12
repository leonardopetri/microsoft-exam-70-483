using System;

namespace Ex28
{
    class Program
    {
        public delegate void Delegate();
        static void Main(string[] args)
        {
            Delegate del = Method1;
            del += Method2;

            del();
            var methods = del.GetInvocationList();

            foreach(var method in methods)
            {
                Console.WriteLine(method.Method);
                Console.WriteLine(method.DynamicInvoke());
            }
        }

        public static void Method1()
        {
            Console.WriteLine("Method 1 Executed!");
        }
        
        public static void Method2()
        {
            Console.WriteLine("Method 2 Executed!");
        }
    }
}
