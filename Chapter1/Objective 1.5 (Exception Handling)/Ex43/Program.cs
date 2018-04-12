using System;
using System.Runtime.ExceptionServices;

namespace Ex43
{
    class Program
    {
        static ExceptionDispatchInfo possibleException = null;
        
        static void Main(string[] args)
        {
            ThrowException();
            if (possibleException != null)
            {
                try
                {
                    possibleException.Throw();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        static void ThrowException()
        {
            try
            {
                throw new ArgumentNullException();
            }
            catch (ArgumentNullException ex)
            {
                possibleException = ExceptionDispatchInfo.Capture(ex);
            }
        }
    }
}
