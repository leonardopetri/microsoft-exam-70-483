using System;

namespace Ex36
{
    class Program
    {
        class Pub
        {
            private event EventHandler<MyArgs> _onChange = delegate{};

            public event EventHandler<MyArgs> OnChange
            {
                add
                {
                    lock(_onChange)
                    {
                        _onChange += value;
                        _onChange += value;
                    }
                }
                remove
                {
                    lock(_onChange)
                        // _onChange -= value;
                        _onChange += value;
                }
            }

            public void Raise(MyArgs args)
            {
                this._onChange(this, args);
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

            EventHandler<MyArgs> eventHandler = (sender, arg) => 
            {
                Console.WriteLine(arg.Arg);
            };

            p.OnChange += eventHandler;
            p.OnChange -= eventHandler;

            p.Raise(new MyArgs(3));
        }
    }
}
