using System;

namespace Ex35
{
    class Program
    {
        class Pub
        {
            public event EventHandler<MyArgs> OnChange = delegate{};

            public void Raise(MyArgs args)
            {
                this.OnChange(this, args);
            }
        }

        class MyArgs : EventArgs
        {
            public int Arg { get; set; }

            public MyArgs(int arg)
            {
                this.Arg = arg;
            }
        }

        static void Main(string[] args)
        {
            RaiseOnChange();
        }

        static void RaiseOnChange()
        {
            var p = new Pub();

            p.OnChange += (sender, arg) => 
            {
                Console.WriteLine(arg.Arg);
            };

            p.Raise(new MyArgs(3));
        }
    }
}
