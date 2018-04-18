using System;
using System.IO;

namespace Ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            object stream = new MemoryStream();
            MemoryStream memoryStream = (MemoryStream)stream;

            Console.WriteLine($"stream = {stream}");
            Console.WriteLine($"memoryStream = {memoryStream}");
        }
    }
}
