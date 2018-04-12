using System;

namespace Ex33
{
    class Program
    {
        class Pub
        {
            public Action OnChange { get; set; }

            public void Raise()
            {
                if (OnChange != null)
                {
                    OnChange();
                }
            }
        }

        static void Main(string[] args)
        {
            RaiseOnChange();
        }

        public static void RaiseOnChange()
        {
            var p = new Pub();
            // p.OnChange();
            p.Raise();

            p.OnChange = () => Console.WriteLine("Raise OnChange 1");
            p.OnChange();

            p.OnChange += () => Console.WriteLine("Raise OnChange 2");

            p.Raise();
        }
    }
}
