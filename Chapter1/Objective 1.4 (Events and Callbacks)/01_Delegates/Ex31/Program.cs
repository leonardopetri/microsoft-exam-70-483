using System;

namespace Ex31
{
    class Program
    {
        public delegate int Operation(int x, int y);

        static void Main(string[] args)
        {
            Operation op = (x,y) => (x+y);
            Console.WriteLine(op(4,3));
            
            op = (x,y) => (x*y);
            Console.WriteLine(op(4,3));
            
            op += (x,y) => (x+y);
            foreach(var i in op.GetInvocationList())
                Console.WriteLine(i.DynamicInvoke(4,3));
        }
    }
}