using System;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = Task.Run(() => {
                var sum = 0;
                for (var i = 0; i < 20; i++) {
                    sum += i;
                }
                return sum;
            });
            var continueWithTask = task.ContinueWith(t => {
                Console.WriteLine($"Continue With Result: {t.Result}");
            });

            // Task.WaitAll(task, continueWithTask);

            Console.WriteLine($"Result: {task.Result}");

            Task.WaitAll(task, continueWithTask);
        }
    }
}
