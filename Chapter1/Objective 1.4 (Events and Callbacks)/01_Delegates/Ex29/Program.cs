using System;
using System.IO;

namespace Ex29
{
    class Program
    {
        public delegate TextWriter ConvarianceDel();
        static void Main(string[] args)
        {
            ConvarianceDel del = Stream;
            del += String;

            del();
        }

        public static StreamWriter Stream()
        {
            Console.WriteLine("StreamWriter");
            return null;
        }

        public static StringWriter String()
        {
            Console.WriteLine("StringWriter");
            return null;
        }
    }
}
