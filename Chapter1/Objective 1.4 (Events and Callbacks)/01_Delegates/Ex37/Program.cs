using System;

namespace Ex37
{
    class Program
    {
        class Pub
        {
            public event EventHandler OnChange = delegate{};

            public void Raise()
            {
                this.OnChange(this, null);
            }
        }

        static void Main(string[] args)
        {
            RaiseOnChange();
        }

        static void RaiseOnChange()
        {
            var p = new Pub();

            p.OnChange += (sender, args) =>
            {
                Console.WriteLine("First Event!");
            };
            
            p.OnChange += (sender, args) =>
            {
                throw new Exception();
            };
            
            p.OnChange += (sender, args) =>
            {
                Console.WriteLine("Third Event!");
            };

            p.Raise();
        }
    }
}
