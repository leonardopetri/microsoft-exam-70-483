using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            CallingMethod();
        }

        private static void MyMethod(int firstArgument, string secondArgument = "default value", bool thirdArgument = false)
        {
            Console.WriteLine($"{firstArgument} {secondArgument} {thirdArgument}");
        }

        // private static void MyMethod1(int firstArgument, string secondArgument = "default value", bool thirdArgument, int fourthArgument = 10)
        // {
        //     Console.WriteLine($"{firstArgument} {secondArgument} {thirdArgument}");
        // }

        private static void MyMethod1(string firstArgument, params int[] secondArgument)
        {
            Console.WriteLine($"{firstArgument} {secondArgument}");
        }

        private static void CallingMethod()
        {
            MyMethod(1, thirdArgument: true);
            MyMethod(2, "test");
            MyMethod(3);
            MyMethod(firstArgument: 4, thirdArgument: false, secondArgument: "second");
            MyMethod1("Teste");
            MyMethod1("Teste 2", 3,4,5,6);
        }
    }
}
