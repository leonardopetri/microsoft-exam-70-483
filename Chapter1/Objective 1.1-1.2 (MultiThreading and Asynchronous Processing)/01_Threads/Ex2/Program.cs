using System;
using System.Linq;
using System.Threading;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            var thread = new Thread(() => {
                foreach (var i in Enumerable.Range(0, 30)) {
                    Console.WriteLine($"Helper Thread ({Thread.CurrentThread.ManagedThreadId}): {i}");
                    // Thread.Sleep(0);
                    // Thread.Sleep(1);
                    //Thread.Yield();
                }
            });
            thread.Start();

            foreach (var i in Enumerable.Range(0, 30)) {
                Console.WriteLine($"Helper Thread ({Thread.CurrentThread.ManagedThreadId}): {i}");
                // Thread.Sleep(0);
                // Thread.Sleep(1);
                //Thread.Yield();
            }
        }
    }
}
