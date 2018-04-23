using System;

namespace Ex21.OtherNamespece
{
    public class Derived2 : Base
    {
        public void MyDerivedMethod()
        {
            // _privateField = 41; // Not OK, this will generate a compile error
            _protectedField = 44; // OK, protected fields can be accessed
            _internalField = 45; // OK, internal fields can be accessed in other namespaces

            // MyPrivateMethod(); // Not OK, this will generate a compile error
            MyProtectedMethod(); // OK, protected methods can be accessed
            MyInternalMethod(); // OK, internal methods can be accessed in other namespaces
        }
    }
}