using System;
using System.Linq;

namespace Ex19
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);
            try {
                var parrallelResult = numbers.AsParallel().Where(IsNotTenMultiple);
                parrallelResult.ForAll(Console.WriteLine);
            } catch (AggregateException e) {
                Console.WriteLine($"There were {e.InnerExceptions.Count} exceptions.");
                Console.WriteLine(e.InnerException.ToString());
            }
        }

        private static bool IsNotTenMultiple(int i)
        {
            if (i % 10 == 0) {
                throw new ArgumentException("i");
            }
            return i % 2 == 0;
        }
    }
}
