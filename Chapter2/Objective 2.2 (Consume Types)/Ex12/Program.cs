using System;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Concat("To box or not box", 42, true));
            int i = 42;
            //boxing
            object o = i;
            Console.WriteLine(o);
            //unboxing
            int x = (int)o;
            Console.WriteLine(x);
        }
    }
}
