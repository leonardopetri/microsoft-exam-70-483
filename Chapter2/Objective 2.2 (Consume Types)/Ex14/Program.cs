using System;
using System.Net.Http;

namespace Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            object o = client;
            IDisposable d = client;

            Console.WriteLine($"client = {client}");
            Console.WriteLine($"o = {o}");
            Console.WriteLine($"d = {d}");
        }
    }
}
