using System;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Product() { Price = 1000 };
            var calc = new Calculator();
            Console.WriteLine($"Discount of {p.Price} is {calc.CalculateDiscount(p)}");

            var clone = p.CloneProductWithDiscount<Product>();
            Console.WriteLine($"Price of cloned product is: {clone.Price}");
        }
    }

    public class Product
    {
        public decimal Price { get; set; }
    }

    public static class ProductExtension
    {
        public static decimal Discount(this Product product)
        {
            return product.Price * .9M;
        }

        public static T CloneProductWithDiscount<T>(this Product product) where T : Product, new()
        {
            T copy = new T()
            {
                Price = product.Discount()
            };

            return copy;
        }
    }

    public class Calculator
    {
        public decimal CalculateDiscount(Product product)
        {
            return product.Discount();
        }
    }
}
