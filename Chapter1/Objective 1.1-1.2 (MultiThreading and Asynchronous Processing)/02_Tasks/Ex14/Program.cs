using System;
using System.Threading.Tasks;

namespace Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            var parent = Task.Run(() => {
                var results = new int[3];
                var tasks = new Task[3];
                tasks[0] = new Task(() => results[0] = 0);
                tasks[0].Start();
                tasks[1] = new Task(() => results[1] = 1);
                tasks[1].Start();
                tasks[2] = new Task(() => results[2] = 2);
                tasks[2].Start();
                Task.WaitAll(tasks);
                return results;
            });

            var finalTask = parent.ContinueWith(parentTask => {
                foreach (var i in parentTask.Result) {
                    Console.WriteLine(i);
                }
            });

            finalTask.Wait();
        }
    }
}
