using System;

namespace Ex27
{
    class Program
    {
        public delegate int Operation(int x, int y);

        static void Main(string[] args)
        {
            Operation op = Sum;
            Console.WriteLine($"Sum result: {op(3,4)}");
            
            op = Multiply;
            Console.WriteLine($"Sum result: {op(3,4)}");
        }

        public static int Sum(int x, int y)
        {
            return x + y;
        }
        
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
