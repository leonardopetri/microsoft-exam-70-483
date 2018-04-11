using System;
using System.Linq;
using System.Threading;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            var thread = new Thread(() => {
                foreach (var i in Enumerable.Range(0, 30)) {
                    Console.WriteLine($"Helper Thread ({Thread.CurrentThread.ManagedThreadId}): {i}");
                    Thread.Sleep(1);
                }
            });
            thread.IsBackground = true;
            thread.Start();
            foreach (var i in Enumerable.Range(0, 30)) {
                Console.WriteLine($"Main Thread ({Thread.CurrentThread.ManagedThreadId}): {i}");
                Thread.Sleep(0);
            }

            Console.WriteLine("Main Thread starts waiting...");
            // This blocks the Main Thread until the Helper Thread is done.
            thread.Join();
            Console.WriteLine("Helper Thread joined.");
        }
    }
}
