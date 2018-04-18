using System;
using System.Dynamic;

namespace Ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic obj = new SampleObject();
            Console.WriteLine(obj.SomeProperty);

            dynamic obj2 = new ExpandoObject();
            obj2.Test = "This is a test property";
            obj2.Test2 = "This is a test2 property";
            Console.WriteLine(obj2.Test);
            Console.WriteLine(obj2.Test2);

            dynamic obj3 = new { Test = "Testing" };
            // obj3.Test2 = "Testing2";
            Console.WriteLine(obj3.Test);
            // Console.WriteLine(obj3.Test2);
        }
    }

    public class SampleObject : DynamicObject
    {
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            Console.WriteLine(binder.Name);
            result = binder.Name;
            return true;
        }
    }
}
