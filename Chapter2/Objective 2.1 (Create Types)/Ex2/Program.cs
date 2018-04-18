using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(1, 1);
            var p2 = p;

            p2.x = 3;

            Console.WriteLine(p);
            Console.WriteLine(p2);
        }
    }

    public struct Point
    {
        public int x {private get;set;}
        public int y {private get;set;}

        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }

        public override string ToString()
        {
            return $"{x} {y}";
        }
    }
}
