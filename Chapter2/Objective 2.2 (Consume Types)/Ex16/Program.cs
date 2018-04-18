using System;

namespace Ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = new Money(150.2M);
            int a = (int)money;
            decimal b = money;

            Console.WriteLine(money.ToString());
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }

    public class Money
    {
        public decimal Amount { get; set; }

        public Money(decimal amount)
        {
            this.Amount = amount;
        }

        public static implicit operator decimal(Money money)
        {
            return money.Amount;
        }

        public static explicit operator int(Money money)
        {
            return (int)money.Amount;
        }

        public override string ToString()
        {
            return this.GetType().ToString();
        }
    }
}
