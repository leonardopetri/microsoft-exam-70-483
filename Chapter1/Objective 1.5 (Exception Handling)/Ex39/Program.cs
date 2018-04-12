using System;

namespace Ex39
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "NaN";

            //Leave the program.
            // var i = int.Parse(s);

            //Handle the exception
            try
            {
                var i = int.Parse(s);
            }
            catch (FormatException)
            {
                Console.WriteLine($"{s} is not a valid number. Please try again.");
            }

            // string a = "NaN"; // Throws FormatException
            string a = null; // Throws ArgumentNullException

            try
            {
                var i = int.Parse(a);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("You need to enter a value.");
            }
            catch (FormatException)
            {
                Console.WriteLine($"{s} is not a valid number. Please try again.");
            }
            finally
            {
                Console.WriteLine("Program Completed!");
            }
        }
    }
}
