using System;
using Ex21;

namespace Ex22
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj1 = new Derived();
            obj1.DerivedMethod();

            var obj2 = new Base();
            //obj2._protectedField //Cannot access protected field
        }
    }

    public class Derived : Base
    {
        public void DerivedMethod()
        {
            _protectedField = 45;
            //_internalField = 45; //Cannot access
            //_protectedInternalField = 45 //Cannot access

            MyProtectedMethod();
        }
    }
}
