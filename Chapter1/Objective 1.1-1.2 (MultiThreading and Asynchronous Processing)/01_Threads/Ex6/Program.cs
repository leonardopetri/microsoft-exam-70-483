using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            var thread = new Thread(() => {
                foreach (var i in Enumerable.Range(0, 30))
                {
                    Debug.WriteLine($"Helper Thread ({Thread.CurrentThread.ManagedThreadId}): {i}");
                    Thread.Sleep(0);
                }
            });

            thread.IsBackground = true;
            thread.Start();
            foreach (var i in Enumerable.Range(0, 10))
            {
                Debug.WriteLine($"Main Thread ({Thread.CurrentThread.ManagedThreadId}): {i}");
                Thread.Sleep(0);
            }
        }
    }
}
