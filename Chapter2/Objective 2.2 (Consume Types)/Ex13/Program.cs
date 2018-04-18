using System;

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 42;
            //implicity conversion
            double d = i;
            Console.WriteLine($"d = {d}");
            
            double x = 1234.7;
            int a;
            // Cast double to int
            a = (int)x;

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"a = {a}");
        }
    }
}
