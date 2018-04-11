using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ex25
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            var t1 = Task.Run(() => 
            {
                Interlocked.CompareExchange(ref i, 5, 1);
            });

            var t2 = Task.Run(() => 
            {
                Interlocked.CompareExchange(ref i, 1, 5);
            });

            Task.WaitAll(t1,t2);
            Console.WriteLine(i);
        }
    }
}
