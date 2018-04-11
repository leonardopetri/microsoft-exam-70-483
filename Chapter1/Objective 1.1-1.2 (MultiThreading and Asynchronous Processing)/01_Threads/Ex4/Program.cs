using System;
using System.Linq;
using System.Threading;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {var thread = new Thread(() => {
                foreach (var i in Enumerable.Range(0, 30)) {
                    Console.WriteLine($"Helper Thread ({Thread.CurrentThread.ManagedThreadId}): {i}");
                    Thread.Sleep(0);
                }
            });

            thread.Priority = ThreadPriority.Highest;
            thread.Start();
            foreach (var i in Enumerable.Range(0, 30)) {
                Console.WriteLine($"Main Thread ({Thread.CurrentThread.ManagedThreadId}): {i}");
                Thread.Sleep(0);
            }
        }
    }
}
