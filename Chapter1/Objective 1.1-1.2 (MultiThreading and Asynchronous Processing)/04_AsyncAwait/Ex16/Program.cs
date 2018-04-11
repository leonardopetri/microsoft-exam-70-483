using System;
using System.Threading;

namespace Ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm going to wait 5 seconds.");
            TimeoutAsync(TimeSpan.FromSeconds(5), () => {
                Console.WriteLine("I waited 5 seconds.");
                TimeoutAsync(TimeSpan.FromSeconds(5), () => {
                    Console.WriteLine("I waited another 5 seconds.");
                });
            });
            Console.WriteLine("I can do other stuff in the meantime");

            
        }

        // Some Asynchronous Method
        public static void TimeoutAsync(TimeSpan timeout, Action onTimeout)
        {
            Console.WriteLine("Waiting for timeout.");
            new Timer(state => onTimeout(), null, timeout, TimeSpan.FromMilliseconds(-1));
        }
    }
}
