using System;
using System.Threading;

namespace Ex26
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            destination:
            Console.WriteLine("Enter the program!");
            if (x == 1)
            {
                Thread.Sleep(1000);
                goto destination;
            }
        }
    }
}
