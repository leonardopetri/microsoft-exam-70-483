using System;

namespace Ex42
{
    class Program
    {
        public class C1
        {
            public void Method()
            {
                throw new ArgumentNullException();
            }
        }

        public class C2
        {
            public void ThrowOriginalException()
            {
                try
                {
                    var c1 = new C1();
                    c1.Method();
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public void MessWithStackTrace()
            {
                try
                {
                    var c1 = new C1();
                    c1.Method();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void RightWayToAddInfoToNewException()
            {
                try
                {
                    var c1 = new C1();
                    c1.Method();
                }
                catch (Exception ex)
                {
                    throw new Exception("New Exception", ex);
                }
            }

            public void WrongWayToAddInfoToNewException()
            {
                try
                {
                    var c1 = new C1();
                    c1.Method();
                }
                catch (Exception)
                {
                    throw new Exception("New Exception");
                }
            }
        }
        
        static void Main(string[] args)
        {
            try
            {
                var c2 = new C2();
                c2.ThrowOriginalException();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Original StackTrace {ex.StackTrace}\n");
                if(ex.InnerException != null)
                    Console.WriteLine($"InnerException StackTrace {ex.InnerException.StackTrace}");
            }

            Console.WriteLine();
            Console.WriteLine();

            try
            {
                var c2 = new C2();
                c2.MessWithStackTrace();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Original StackTrace {ex.StackTrace}\n");
                if(ex.InnerException != null)
                    Console.WriteLine($"InnerException StackTrace {ex.InnerException.StackTrace}");
            }

            Console.WriteLine();
            Console.WriteLine();

            try
            {
                var c2 = new C2();
                c2.RightWayToAddInfoToNewException();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Original StackTrace {ex.StackTrace}\n");
                if(ex.InnerException != null)
                    Console.WriteLine($"InnerException StackTrace {ex.InnerException.StackTrace}");
            }
            
            Console.WriteLine();
            Console.WriteLine();
            
            try
            {
                var c2 = new C2();
                c2.WrongWayToAddInfoToNewException();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Original StackTrace {ex.StackTrace}\n");
                if(ex.InnerException != null)
                    Console.WriteLine($"InnerException StackTrace {ex.InnerException.StackTrace}");
            }
        }
    }
}
