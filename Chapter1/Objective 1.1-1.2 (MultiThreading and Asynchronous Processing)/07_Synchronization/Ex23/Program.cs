using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ex23
{
    class Program
    {
        static void Main(string[] args)
        {
            var lockA = new object();
            var lockB = new object();

            var up = Task.Run(() => {
                lock (lockA) {
                    Console.WriteLine("Locked A on up");
                    Thread.Sleep(3000);
                    lock (lockB) {
                        Console.WriteLine("Locked A and B on up");
                    }
                }
            });

            lock (lockB) {
                Console.WriteLine("Locked B on main");
                lock (lockA) {
                    Console.WriteLine("Locked A and B on main");
                }
            }
            up.Wait();
        }
    }
}
