﻿using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Ex20
{
    class Program
    {
        static void Main(string[] args)
        {
            var col = new BlockingCollection<string>();
            Task.Run(() => {
                while (true) {
                    Console.WriteLine(col.Take());
                }
//                foreach (var v in col.GetConsumingEnumerable()) {
//                    Console.WriteLine(v);
//                }
            });
            Console.WriteLine("Enter white space to quit");
            var write = Task.Run(() => {
                while (true) {
                    var s = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(s)) {
                        break;
                    }
                    col.Add(s);
                }
            });
            write.Wait();
        }
    }
}
