using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            var cts = new CancellationTokenSource();
            var task = Task.Run(() => {
                var sum = 0;
                for (var i = 0; i < 10; i++) {
                //for (var i = 0; i < 2E6; i++) {
                    checked {
                        sum += i;
                    }
                }
                return sum;
            }, cts.Token);
            var canceledTask = task.ContinueWith(t => {
                Console.WriteLine("Task is canceled.");
            }, TaskContinuationOptions.OnlyOnCanceled);
            var faultedTask = task.ContinueWith(t => {
                Console.WriteLine("Task faulted.");
            }, TaskContinuationOptions.OnlyOnFaulted);
            var completedtask = task.ContinueWith(t => {
                Console.WriteLine($"Result: {t.Result}");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            //cts.Cancel();
            try {
                completedtask.Wait(cts.Token);
            } catch (Exception e) {
                Console.WriteLine(e);
            }
            
            Task.WaitAny(canceledTask, faultedTask);
        }
    }
}
