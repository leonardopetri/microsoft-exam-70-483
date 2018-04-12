using System;

namespace Ex40
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var s = 43;
                // var s = 42;
                if (s == 42)
                    Environment.FailFast("Special Number");
    
                Environment.FailFast("Not a Special Number");
            }
            //Obsolete Exception
            // catch(System.ExecutionEngineException)
            // {
            //     Console.WriteLine("Does not reach!");
            // }
            catch (System.Exception)
            {
                Console.WriteLine("Does not reach!");
            }
            finally
            {
                Console.WriteLine("Program Completed!");
            }
        }
    }
}
