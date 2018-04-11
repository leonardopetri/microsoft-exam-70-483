using System;
using System.Linq;
using System.Threading;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(s => {
                foreach (var i in Enumerable.Range(0, 20)) {
                    Console.WriteLine($"Helper Thread ({Thread.CurrentThread.ManagedThreadId}): {i}");
                    Thread.Sleep(0);
                }
            });

            // int workerThreads;
            // int completionPortThreads;

            // ThreadPool.GetAvailableThreads(out workerThreads, out completionPortThreads);

            // Console.WriteLine(workerThreads);
            // Console.WriteLine(completionPortThreads);
        }
    }
}
