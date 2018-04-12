using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex38
{
    class Program
    {
        class Pub
        {
            public event EventHandler OnChange = delegate{};

            public void Raise()
            {
                var exceptions = new List<Exception>();
                
                foreach(var handler in OnChange.GetInvocationList())
                {
                    try
                    {
                        handler.DynamicInvoke(this, null);
                    }
                    catch (Exception e)
                    {
                        exceptions.Add(e);
                    }
                }

                if (exceptions.Any())
                {
                    throw new AggregateException(exceptions);
                }
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
            
            try
            {
                p.Raise();
            }
            catch (AggregateException e)
            {
                Console.WriteLine(e.InnerExceptions.Count);
            }
        }
    }
}
