using System;
using System.Data.Common;
using System.Data.SqlClient;

namespace Ex19
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Throw exception Exception");
                // throw new NullReferenceException("Null reference exception");
                throw new InvalidOperationException("You can not do so");
            }
            catch (Exception ex)
            {
                if(ex is Exception)
                {
                    Console.WriteLine("exception is just an exception");
                }
                
                if (ex is InvalidOperationException)
                {
                    Console.WriteLine("exception is of type invalidoperationException");
                }
                
                var sqlEx = ex as NullReferenceException;
                if(sqlEx != null)
                {
                    Console.WriteLine($"Error Message = {sqlEx.Message}");
                }
                else
                {
                    Console.WriteLine("We are not handling a null reference exception");
                }
            }
        }
    }
}
