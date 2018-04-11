using System;
using System.Threading;

namespace Ex7
{
    class Program
    {
        static int field;

        static void Main(string[] args)
        {
            var thread = new Thread(() => {
                for (var i = 0; i < 10; i++) {
                    field++;
                    Thread.Sleep(0);
                }
                Console.WriteLine($"Last value of field on Helper Thread ({Thread.CurrentThread.ManagedThreadId}): {field}");
            });

            thread.Start();
            var anotherThread = new Thread(() => {
                for (var i = 0; i < 10; i++) {
                    field++;
                    Thread.Sleep(0);
                }
                Console.WriteLine($"Last value of field on Helper Thread ({Thread.CurrentThread.ManagedThreadId}): {field}");
            });
            anotherThread.Start();
        }
    }
}
