using System;

namespace Ex20
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog("TEST");
            Console.WriteLine(dog.MyProperty);
            dog.Bark();

            // Console.WriteLine(dog._myField);
            dog.MyProperty = "TEST2";
            Console.WriteLine(dog.MyProperty);
            dog.Bark();
        }
    }

    public class Dog 
    {
        private string _myField;

        public string MyProperty
        {
            get { return _myField; }
            set { _myField = value; }
        }

        public Dog(string myField)
        {
            _myField = myField;
        }

        public void Bark()
        {
            Console.WriteLine($"Bark, bark!\n{_myField}\n");
        }
    }
}
