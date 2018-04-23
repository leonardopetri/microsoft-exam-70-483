using System;
using Ex21.OtherNamespece;

namespace Ex21
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Derived();
            obj.MyDerivedMethod();
            
            var obj2 = new Derived2();
            obj2.MyDerivedMethod();

            var obj3 = new DefaultClass();//Default class is internal
            // obj3.DefaultMethod(); //Cannot access

            var obj4 = new Base();
            obj4._internalField = 45;
            obj4._protectedInternalField = 46;
            //obj4._protectedField = 47; //Cannot access
            obj4.MyInternalMethod();
            obj4.MyProtectedInternalMethod();
            // obj4.MyProtectedMethod(); //Cannot access
        }
    }

    class DefaultClass
    {
        int _defaultField = 10;
        int DefaultProperty { get; set; }

        void DefaultMethod()
        {
            Console.WriteLine($"Default Method {_defaultField}");
        }
    }

    public class Base
    {
        private int _privateField = 42;
        protected int _protectedField = 42;

        //internals can be accessed by a friendly asssembly
        internal int _internalField = 42;
        protected internal int _protectedInternalField = 42;
        int _defaultField = 42;

        private void MyPrivateMethod() {
            Console.WriteLine(nameof(MyPrivateMethod)+" "+_privateField);
        }

        protected void MyProtectedMethod() {
            MyPrivateMethod(); // OK, since we are in the base class
            Console.WriteLine(nameof(MyProtectedMethod)+" "+_protectedField);
        }
        
        //internals can be accessed by a friendly asssembly
        internal void MyInternalMethod() {
            Console.WriteLine(nameof(MyInternalMethod)+" "+_internalField);
        }
        
        protected internal void MyProtectedInternalMethod() {
            Console.WriteLine(nameof(MyProtectedInternalMethod)+" "+_protectedInternalField);
        }
        
        void MyDefaultMethod() {
            Console.WriteLine(nameof(MyDefaultMethod)+" "+_defaultField);
        }
    }

    public class Derived : Base
    {
        public void MyDerivedMethod()
        {
            // _privateField = 41; // Not OK, this will generate a compile error
            _protectedField = 43; // OK, protected fields can be accessed
            // _defaultField = 43; // Default fields are private
            _protectedInternalField = 43;

            // MyPrivateMethod(); // Not OK, this will generate a compile error
            MyProtectedMethod(); // OK, protected methods can be accessed
            // MyDefaultMethod(); // Dafault methods are private
            MyProtectedInternalMethod();
        }
    }
}