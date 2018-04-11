using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ex24
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;

            var t1 = Task<int>.Run(() => {
                if (n == 1) {
                    Thread.Sleep(5000);
                    n = 2;
                    return n;
                }

                return 0;
            });
            
            n = 3;
            
            Console.WriteLine(t1.Result);
            Console.WriteLine(n);

            var t2 = Task.Run(() => {
                if (Interlocked.Exchange(ref n, 5) == 3) 
                {
                    Console.WriteLine(n);
                }
            });

            //n = 4;
            t2.Wait();
            // Console.WriteLine(n);
        }
    }
}
