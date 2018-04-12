using System;

namespace Ex34
{
    class Program
    {
        class Pub
        {
            public event Action OnChange1;
            public event Action OnChange2 = delegate{};

            public void RaiseOnChange1()
            {
                // if (OnChange1 != null)
                    OnChange1();
            }

            public void RaiseOnChange2()
            {
                OnChange2();
            }
        }
        static void Main(string[] args)
        {
            RaiseOnChanges();
        }

        static void RaiseOnChanges()
        {
            var p = new Pub();
            // p.OnChange1();
            // p.RaiseOnChange1();
            p.RaiseOnChange2();

            p.OnChange1 += () => Console.WriteLine("OnChange 1 1");
            p.OnChange1 += () => Console.WriteLine("OnChange 1 2");
            p.RaiseOnChange1();
            
            p.OnChange2 += () => Console.WriteLine("OnChange 2 1");
            Action ac = () => Console.WriteLine("OnChange 2 2");
            p.OnChange2 += ac;
            p.RaiseOnChange2();

            p.OnChange2 -= () => Console.WriteLine("OnChange 2 1");
            p.OnChange2 -= ac;
            p.RaiseOnChange2();
        }
    }
}
