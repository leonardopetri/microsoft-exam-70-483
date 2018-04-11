using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Ex21
{
    class Program
    {
        static void Main(string[] args)
        {
            var bag = new ConcurrentBag<int>();
            var t1 = Task.Run(() => {
                bag.Add(42);
                Thread.Sleep(10000);
                bag.Add(21);
            });

            var t2 = Task.Run(() => {
                while(true) {
                    int result;
                    if(bag.TryTake(out result))
                        Console.WriteLine(result);
                }
            });

            Task.WaitAll(t1,t2);
        }
    }
}
