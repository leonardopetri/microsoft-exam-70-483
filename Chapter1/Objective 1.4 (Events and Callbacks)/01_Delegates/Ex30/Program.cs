using System;
using System.IO;

namespace Ex30
{
    class Program
    {
        public delegate void ContravarianceDel1(StreamWriter stream);
        public delegate void ContravarianceDel2(StringWriter stream);

        static void Main(string[] args)
        {
            ContravarianceDel1 del1 = Text;
            ContravarianceDel1 del2 = Text;
            del1(null);
            del2(null);
        }

        public static void Text(TextWriter text)
        {
            Console.WriteLine("Text Writer");
        }
    }
}
