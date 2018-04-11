using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ex22
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 0;
            var m = 0;
            var @lock = new object();
            var up = Task.Run(() => {
                for (var i = 0; i < 1E6; i++) {
                    lock (@lock) {
                        n++;
                    }
                    Interlocked.Increment(ref m);
                }
            });
            var down = Task.Run(() => {
                for (var i = 0; i < 1E6; i++) {
                    lock (@lock) {
                        n--;
                    }
                    Interlocked.Decrement(ref m);
                }
            });

            Task.WaitAll(up, down);
            Console.WriteLine(n);
            Console.WriteLine(m);
        }
    }
}
