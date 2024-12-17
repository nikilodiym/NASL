using System;

namespace NASL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money(10, 50);
            Console.WriteLine("Money amount: " + money.ToString());

            Product product = new Product("Apple", money);
            Console.WriteLine("Product price: " + product.GetPrice().ToString());

            product.ReducePrice(5, 25);
            Console.WriteLine("Reduced product price: " + product.GetPrice().ToString());
        }
    }

    public class Money
    {
        public int dollars;
        public int cents;

        public Money(int dollars, int cents)
        {
            this.dollars = dollars;
            this.cents = cents;
        }

        public override string ToString()
        {
            return dollars + "." + cents;
        }
    }

    public class Product
    {
        private string name;
        private Money price;

        public Product(string name, Money price)
        {
            this.name = name;
            this.price = price;
        }

        public Money GetPrice()
        {
            return price;
        }

        public void ReducePrice(int dollars, int cents)
        {
            int totalCents = price.cents + price.dollars * 100;
            int reductionCents = cents + dollars * 100;

            int newTotalCents = totalCents - reductionCents;

            price.dollars = newTotalCents / 100;
            price.cents = newTotalCents % 100;
        }
    }
}
