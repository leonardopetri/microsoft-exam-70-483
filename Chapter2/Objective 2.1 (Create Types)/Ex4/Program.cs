using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            MyClass instance2 = instance;
            instance.MyInstanceField = "Some New Value";
            MyClass.MyStaticField = 43;
            instance2.MyInstanceField = "New Value Again";

            instance.Concatenete("1");
            instance.Concatenete("2");
        }
    }

    public class MyClass
    {
        public string MyInstanceField;

        public static int MyStaticField = 42;

        public void Concatenete(string valueToAppend)
        {
            Console.WriteLine(MyInstanceField + " " + valueToAppend);
        }
    }
}
