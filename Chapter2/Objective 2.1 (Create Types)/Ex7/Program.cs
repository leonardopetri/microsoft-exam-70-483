using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance = new MyNullable<int>(3);
            Console.WriteLine($"my number: {instance.HasValue} => {instance.Value}");
        }
    }

    public struct MyNullable<T> where T : struct
    {
        private bool _hasValue;
        private T _value;

        public bool HasValue { get {return _hasValue; } }

        public T Value 
        {
            get
            {
                if (!HasValue)
                    throw new ArgumentNullException();
                
                return _value;
            }
        }

        public MyNullable(T value)
        {
            _hasValue = true;
            _value = value;
        }
    }
}
