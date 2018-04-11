using System;
using System.Threading;

namespace Ex8
{
    class Program
    {
        static readonly ThreadLocal<int> Field = new ThreadLocal<int>(InitializeField);

        static int InitializeField()
        {
            return Thread.CurrentThread.ManagedThreadId;
        }

        private static void Main(string[] args)
        {
            var thread = new Thread(() => {
                for (var i = 0; i < Field.Value; i++) {
                    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}: {i}");
                    Thread.Sleep(0);
                }
            });

            thread.Start();
            var anotherThread = new Thread(() => {
                for (var i = 0; i < Field.Value; i++) {
                    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}: {i}");
                    Thread.Sleep(0);
                }
            });
            anotherThread.Start();
        }
    }
}
