using System;

namespace Ex32
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> ac = (x,y) =>
            {
                Console.WriteLine(x+y);
            };
            ac(4,3);
            
            Func<int, int, int> fu = (x,y) =>
            {
                return x*y;
            };
            Console.WriteLine(fu(4,3));
        }
    }
}
