using System;
using System.Linq;
using System.Threading;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            var thread = new Thread(() => {
                foreach (var i in Enumerable.Range(0, 30)) {
                    try {
                        Console.WriteLine($"Helper Thread ({Thread.CurrentThread.ManagedThreadId}): {i}");
                        Thread.Sleep(0);
                    } catch (ThreadAbortException) {
                        Console.WriteLine("Helper Thread was aborted.");
                    }
                }
            });

            thread.Start();
            foreach (var i in Enumerable.Range(0, 10)) {
                Console.WriteLine($"Main Thread ({Thread.CurrentThread.ManagedThreadId}): {i}");
                Thread.Sleep(0);
            }

            //Abort is not suported in .Net Core 2.0
            //thread.Abort();
        }
    }
}
